using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moomoo_Client
{
    public partial class SpinMover : Control
    {
        Point lastClick;
        public delegate void SpunEventHandler(object s, SpunEventArgs e);
        public event SpunEventHandler Spun;
        protected virtual void OnSpun(SpunEventArgs e) {
            SpunEventHandler handler = Spun;
            if (handler != null)
            {
                handler?.Invoke(this, e);
            }
        }
        public class SpunEventArgs : EventArgs
        {
            public double Angle { get; }
            public SpunEventArgs(double angle)
            {
                Angle = angle;
            }
        }
        public event EventHandler StopMoving;
        protected virtual void OnStopMoving(EventArgs e)
        {
            EventHandler handler = StopMoving;
            if (handler != null)
            {
                handler?.Invoke(this, e);
            }
        }
        public SpinMover()
        {
            InitializeComponent();
            MouseClick += SpinMover_MouseClick;
            KeyDown += SpinMover_KeyDown;
        }

        private void SpinMover_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && Focused)
            {
                OnStopMoving(new EventArgs());
            }
        }

        private void SpinMover_MouseClick(object sender, MouseEventArgs e)
        {
            lastClick = new Point(e.X,e.Y);
            SpunEventArgs sea = new SpunEventArgs(Math.Atan2(e.Y, e.X));
            Refresh();
            OnSpun(sea);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawLine(Pens.Black, pe.ClipRectangle.Width/2,pe.ClipRectangle.Height/2,lastClick.X,lastClick.Y);
        }
    }
}
