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
    public partial class SpawnForm : Form
    {
        SolidRectangle colorRect;
        string[] skinColors = {"#bf8f54", "#cbb091", "#896c4b", "#fadadc", "#ececec", "#c37373", "#4c4c4c", "#ecaff7", "#738cc3", "#8bc373"};
        public object[] results;
        public SpawnForm()
        {
            InitializeComponent();
            colorRect = new SolidRectangle();
            colorPanel.Controls.Add(colorRect);
            colorRect.Dock = DockStyle.Fill;
            colorRect.colorToPaint = ColorTranslator.FromHtml(skinColors[0]);
            colorRect.Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(@"gay {0}", colorSpinner.Value);
            colorRect.colorToPaint = ColorTranslator.FromHtml(skinColors[decimal.ToInt32(colorSpinner.Value)-1]);
            colorRect.Refresh();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            results = new object[]
            {
                name.Text == ""
                    ? "Moocarina"
                    : name.Text,
                decimal.ToInt32(colorSpinner.Value - 1),
                spawnBonusCheckbox.Checked
            };
            Console.WriteLine("tf");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
