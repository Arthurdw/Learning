using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dubbele_Lus
{
    public partial class doubleLoop : Form
    {
        Graphics g;
        Pen pn;
        Random rn = new Random();
        public doubleLoop()
        {
            InitializeComponent();
            g = pnlDisplay.CreateGraphics();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            // Define:
            int x = 2;
            int y = 2;
            int width_height = 20;
            pn = new Pen(Color.Blue, 2);
            int opacity = 255;
            // Create squares!
            for (int i = 0; i < 22; ++i)
            {
                x = 5;
                for (int j = 0; j < 21; ++j)
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(opacity, rn.Next(0, 256), rn.Next(0, 256), rn.Next(0, 256))), x, y, width_height, width_height);
                    g.DrawRectangle(pn, x, y, width_height, width_height);
                    // g.DrawLine(pn, x, y, x, y + width_height);
                    // g.DrawLine(pn, x - 1, y, x + width_height + 1, y);
                    // g.DrawLine(pn, x + width_height, y, x + width_height, y + width_height);
                    // g.DrawLine(pn, x - 1, y + width_height, x + width_height + 1, y + width_height);
                    x += width_height + 5;
                }
                y += width_height + 5;
                opacity -= 11;
            }
        }
    }
}
