using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Collatz
{
    public partial class Form1 : Form
    {
        private readonly Graphics _g;
        private readonly Pen _pen;
        private readonly Pen _secondPen;

        public Form1()
        {
            InitializeComponent();
            this._g = pnl.CreateGraphics();
            this._g.SmoothingMode = SmoothingMode.AntiAlias;
            this._pen = new Pen(new SolidBrush(Color.DodgerBlue), 2);
            this._secondPen = new Pen(new SolidBrush(Color.LightCoral), 2);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DrawPanelBase(pnl, this._g);

            List<Point> data = new List<Point>();

            int n, s = 0;

            try
            {
                n = int.Parse(txtNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"No valid number was provided!", @"Oops");
                return;
            }
            
            while (n != 1)
            {
                s++;
                data.Add(new Point(s, n));
                if (n % 2 == 0) n /= 2;
                else n = (n * 3) + 1;
            }

            data.Add(new Point(s + 1, n));

            this.DrawStatistics(pnl, this._g, data);
        }

        private void DrawPanelBase(Panel panel, Graphics graphics)
        {
            panel.Refresh();
            graphics.DrawLine(this._pen, 10, 5, 10, panel.Height - 5);
            graphics.DrawLine(this._pen, 0, panel.Height - 15, panel.Width, panel.Height - 15);
        }

        private void DrawStatistics(Panel panel, Graphics graphics, List<Point> data)
        {
            if (data.Count == 0) return;

            int lastY = data.First().Y;
            double impactY = (double) (panel.Height - 20) / data.Max(point => point.Y),
                impactX = (double) (panel.Width - 10) / data.Count;
            int height = panel.Height - 15;

            Console.WriteLine(@"");

            foreach (Point point in data)
            {
                int appX = (int) (point.X * impactX),
                    appY = (int) (point.Y * impactY);
                graphics.DrawLine(this._secondPen, (int) ((point.X - 1) * impactX) + 10, height - lastY, appX + 10, height - appY);
                lastY = appY;
            }
        }
    }
}
