using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InloggenAccountsMultiform
{
    public partial class FrmTekening : Form
    {
        Point[] punten;
        Graphics g;
        public FrmTekening(string naam)
        {
            InitializeComponent();
            lblnaam.Text = naam;
            Init();
        }

        private void Init()
        {
            g = pnlResult.CreateGraphics();
            punten = new Point[] { new Point(10, 10), new Point(390, 10), new Point(390, 390), new Point(200, 200), new Point(10, 390), new Point(10, 10) };
        }

        private void tekenPolygon()
        {
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(420, 666), Color.DarkRed, Color.Blue);
            g.FillPolygon(br, punten);
            g.DrawPolygon(new Pen(Color.LimeGreen, 2), punten);
        }

        private void tekenen(object sender, PaintEventArgs e)
        {
            tekenPolygon();
        }

        private void FrmTekening_Load(object sender, EventArgs e)
        {
            pnlResult.Invalidate();
        }
    }
}
