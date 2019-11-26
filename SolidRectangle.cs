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
    public partial class SolidRectangle : Control
    {
        public Color colorToPaint;
        public SolidRectangle()
        {
            InitializeComponent();
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var bolid = new SolidBrush(colorToPaint);
            pe.Graphics.FillRectangle(bolid, pe.ClipRectangle);
            bolid.Dispose();
        }
    }
}
