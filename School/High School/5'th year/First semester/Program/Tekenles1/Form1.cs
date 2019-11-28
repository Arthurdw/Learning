using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekenles1
{
    public partial class Tekenles : Form
    {
        // Standaard tekenattributen.
        Graphics g;
        Brush br;
        Pen pn;
        public Tekenles()
        {
            InitializeComponent();
            g = PNLTekening.CreateGraphics();
        }

        private void BTNToon_Click(object sender, EventArgs e)
        {
            pn = new Pen(Color.FromArgb(red:200, green:50, blue:40), 3);
            br = new SolidBrush(Color.Tomato);
            g.DrawLine(pn, 10, 50, 200, 300);
            g.DrawRectangle(pn, 225, 50, 150, 80);
            g.FillRectangle(br, 226, 51, 149, 79);
            g.FillEllipse(br, 400, 10, 100, 100);
        }
    }
}
