using System;
using System.Drawing;
using System.Windows.Forms;

namespace rasterKleurenMethodes
{
    public partial class Form1 : Form
    {
        // 237; 124
        Graphics g;
        Brush br;
        Pen pn;
        public Form1()
        {
            InitializeComponent();
            g = pnlShow.CreateGraphics();
        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            drawTriangle(Color.Tomato);
        }
        private void btnLime_Click(object sender, EventArgs e)
        {
            drawTriangle(Color.Lime);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            drawTriangle(Color.Blue);
        }

        private void drawTriangle(Color color)
        {
            br = new SolidBrush(color);
            pn = new Pen(Color.Black);
            int x = 0, y = 0, aantalblokjes = 9, afmeting = 237 / 12, saved_x = 0;

            while (aantalblokjes > 0)
            {
                for (int i = 0; i < aantalblokjes; i++)
                {
                    g.FillRectangle(br, x, y, afmeting, afmeting);
                    g.DrawRectangle(pn, x, y, afmeting, afmeting);
                    x += afmeting;
                }
                saved_x += afmeting;
                x = saved_x;
                aantalblokjes -= 2;
                y += afmeting;
            }
        }
    }
}
