using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konijn
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pnBrown;
        Brush brBeige, brPink, brBlack, brRed, brBrown;
        public Form1()
        {
            InitializeComponent();
            g = PNLToon.CreateGraphics();
        }

        private void BTNStart_Click(object sender, EventArgs e)
        {
            // Colors:
            brBeige = new SolidBrush(Color.Beige);
            brPink = new SolidBrush(Color.LightPink);
            brBlack = new SolidBrush(Color.Black);
            brRed = new SolidBrush(Color.Red);
            brBrown = new SolidBrush(Color.Bisque);
            pnBrown = new Pen(Color.Brown, 3);
            // Draw:
            // Canvas: 565; 684

            // Body:
            g.FillEllipse(brBeige, 130, 300, 300, 400);
            g.FillEllipse(brPink, 240, 630, 30, 100);
            g.FillEllipse(brPink, 290, 630, 30, 100);
            g.FillEllipse(brPink, 240, 630, 30, 100);
            g.FillEllipse(brPink, 290, 630, 30, 100);

            // Head:
            g.FillEllipse(brBrown, 240, 30, 25, 120);
            g.FillEllipse(brBrown, 290, 30, 25, 120);
            g.FillEllipse(brBeige, 190, 120, 180, 200);
            g.FillEllipse(brRed, 220, 160, 30, 50);
            g.FillEllipse(brRed, 290, 160, 30, 50);
            g.FillEllipse(brPink, 220, 230, 30, 40);
            g.FillEllipse(brPink, 290, 230, 30, 40);
            g.FillEllipse(brBlack, 260, 230, 20, 40);
            g.DrawLine(pnBrown, 260, 240, 150, 220);
            g.DrawLine(pnBrown, 255, 250, 140, 250);
            g.DrawLine(pnBrown, 260, 260, 150, 280);
            g.DrawLine(pnBrown, 280, 240, 370, 220);
            g.DrawLine(pnBrown, 285, 250, 375, 250);
            g.DrawLine(pnBrown, 280, 260, 370, 280);
        }
    }
}
