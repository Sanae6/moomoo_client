using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagePack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperSocket.ClientEngine;
using WebSocket4Net;

namespace Moomoo_Client
{
    public partial class MainWindow : Form
    {
        HttpClient client;
        Servers servers;
        WebSocket ws;
        Timer spinTimer;
        private double spinAngle;
        int selfId;
        public MainWindow()
        {
            InitializeComponent();
            SpinMover sm = new SpinMover();
            spinMoverPanel.Controls.Add(sm);
            sm.Spun += Sm_Spun;
            PrepareReset();
            spinTimer = new Timer();
            spinTimer.Interval = 600;
            spinTimer.Tick += SpinTimer_Tick;
        }

        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            Send(JsonConvert.SerializeObject(Spin.Create(spinAngle)));
            spinTimer.Enabled = true;
        }

        public static Task<MainWindow> CreateAsync()
        {
            var ret = new MainWindow();
            return ret.InitializeServers();
        }

        private void EFormClosing(object sender, FormClosingEventArgs e)
        {
            if (ws != null)ws.Close();
        }

        public async Task<MainWindow> InitializeServers() {
            client = new HttpClient();
            Task<HttpResponseMessage> hrm = client.GetAsync("http://moomoo.io/serverData");
            hrm.Wait();
            HttpResponseMessage res = await hrm;
            string data = await res.Content.ReadAsStringAsync();
            servers = JsonConvert.DeserializeObject<Servers>(data);
            indicator.Text = @"Connected: false";
            Enabled = true;
            return this;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (connect.Text == @"Disconnect")
            {
                ws.Close();
                connect.Text = "Connect";
                groupBox1.Enabled = false;
                return;
            }
            indicator.Text = "Connecting...";
            connect.Enabled = false;
            partyKey.Enabled = false;
            var pkey = partyKey.Text.Split(':');
            var s = servers.servers.SingleOrDefault(server => server.matchAgainst(partyKey.Text));
            if(s == null)
            {
                indicator.Text = @"Party key does not match in server list, avoid having spaces in the text box.";
                connect.Enabled = true;
                partyKey.Enabled = true;
                return;
            }
            ws = new WebSocket("wss://ip_" + s.ip + ".moomoo.io:8008/?gameIndex=0");
            ws.DataReceived += Ws_DataReceived;
            ws.Closed += Ws_Closed;
            ws.Opened += Ws_Opened;
            ws.Error += Ws_Closed;
            ws.Open();
        }
        private void Append(string text, params string[] args) {
            msgLog.InvokeEx(ml => ml.AppendText(string.Format(string.Concat(text,Environment.NewLine),args)));
        }
        private Dictionary<Control,bool> groupControls = new Dictionary<Control, bool>();

        private void PrepareReset()
        {
            foreach (Control control in groupBox1.Controls)
            {
                groupControls.Add(control, control.Enabled);
            }
        }
        private void Reset()
        {
            foreach (KeyValuePair<Control,bool> entry in groupControls)
            {
                entry.Key.InvokeEx(c=>c.Enabled = entry.Value);
            }
        }

        private void Ws_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var msg = JArray.Parse(MessagePackSerializer.ToJson(e.Data));
            var type = msg[0].Value<string>();
            Console.WriteLine(msg.ToString());
            switch (type)
            {
                case "1":
                    selfId = msg[1][0].Value<int>();
                    break;
                case "an":
                    Append("{0}[id={1}] wants to join your team.",msg[1][1].Value<string>(), msg[1][0].Value<string>());
                    break;
                case "11":
                    Append("You Died.");
                    Reset();
                    break;
                case "d":
                    Append("I've been told to disconnect? I'm not sure personally, the protocol docs may have a mistake in them.");
                    Append("Even so, I'm still gonna close just cause I'm not sure what'll happen otherwise.");
                    ws.Close();
                    break;
            }
        }

        private void Ws_Opened(object sender, EventArgs e)
        {
            indicator.Text = "Connected: true";
            connect.InvokeEx(connect => {
                connect.Text = @"Disconnect";
                connect.Enabled = true;
            });
            sendJsonButton.InvokeEx(sjb => sjb.Enabled = true);
            button1.Enabled = true;
            groupBox1.InvokeEx(g=>g.Enabled = true);
            Append(@"Connected!");
        }

        private void Ws_Closed(object sender, EventArgs e)
        {
            if (e.GetType().IsEquivalentTo(typeof(ErrorEventArgs))) Console.Error.WriteLine(((ErrorEventArgs)e).Exception.ToString());
            indicator.Text = @"Connected: false";
            ws.Dispose();
            ws = null;
            Reset();
            connect.InvokeEx(connect => connect.Enabled = true);
            sendJsonButton.InvokeEx(sjb => sjb.Enabled = false);
            partyKey.InvokeEx(p=>p.Enabled = true);
        }
        private void Sm_Spun(object s, SpinMover.SpunEventArgs e)
        {
            if (ws.State == WebSocketState.Open)
            {
                spinAngle = e.Angle;
            }
        }
        private void Send(string json) {
            byte[] bytes = MessagePackSerializer.FromJson(json);
            ws.Send(bytes, 0, bytes.Length);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            SpawnForm f = new SpawnForm();
            DialogResult dr = f.ShowDialog();
            Console.WriteLine(dr);
            if (dr == DialogResult.Cancel) return;
            var spawn = Spawn.Create((string)f.results[0], (int)f.results[1], (bool)f.results[2]);
            var json = JsonConvert.SerializeObject(spawn);
            Console.WriteLine(json);
            Send(json);
        }

        private void partyKey_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ws == null)
                connect_Click(sender, e);
        }

        private void jsonField_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sendJsonButton.Enabled)
                sendJsonButton_Click(sender, e);
        }

        private void sendJsonButton_Click(object sender, EventArgs e)
        {
            try
            {
                JToken.Parse(jsonField.Text);
                Send(jsonField.Text);
            }
            catch
            {
                MessageBox.Show(@"That JSON wasn't valid, sorry.");
            }
        }
    }
    public static class SynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }
    }
}
