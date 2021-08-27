using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Collatz2._0
{
    public partial class Form1 : Form
    {
        private readonly Graphics _g;
        private readonly Pen _pen;
        private bool tmrStarted;
        private Random rn;

        public Form1()
        {
            InitializeComponent();
            this._g = pnl.CreateGraphics();
            this._g.SmoothingMode = SmoothingMode.AntiAlias;
            this._pen = new Pen(new SolidBrush(Color.DodgerBlue), 2);
            this.tmrStarted = false;
            this.rn = new Random();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.tmrStarted) drawTimer.Stop();
            else drawTimer.Start();

            btnStart.Text = this.tmrStarted ? "Start" : "Stop";

            this.tmrStarted = !this.tmrStarted;
        }

        private void DrawPanelBase(Panel panel, Graphics graphics)
        {
            graphics.DrawLine(this._pen, 10, 5, 10, panel.Height - 5);
            graphics.DrawLine(this._pen, 0, panel.Height - 15, panel.Width, panel.Height - 15);
        }
        private void DrawStatistics(Panel panel, Graphics graphics, List<Point> data)
        {
            if (data.Count == 0) return;

            this._g.FillRectangle(new SolidBrush(Color.FromArgb(10, Color.White)), 0, 0, pnl.Width, pnl.Height);
            DrawPanelBase(pnl, this._g);

            int lastY = data.First().Y;
            double impactY = (double)(panel.Height - 20) / data.Max(point => point.Y),
                impactX = (double)(panel.Width - 10) / data.Count;
            int height = panel.Height - 17;

            Pen p = new Pen(new SolidBrush(Color.FromArgb(this.rn.Next(256), this.rn.Next(256), this.rn.Next(256))), 2);

            foreach (Point point in data)
            {
                int appX = (int)(point.X * impactX),
                    appY = (int)(point.Y * impactY);
                graphics.DrawLine(p, (int)((point.X - 1) * impactX) + 10, height - lastY, appX + 10, height - appY);
                lastY = appY;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnl.Refresh();
            DrawPanelBase(pnl, this._g);
            txtOut.Clear();
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            List<Point> data = new List<Point>();

            int orn = this.rn.Next(100, 100000);
            int n = orn, s = 0;


            while (n != 1)
            {
                s++;
                data.Add(new Point(s, n));
                if (n % 2 == 0) n /= 2;
                else n = (n * 3) + 1;
            }

            data.Add(new Point(s + 1, n));


            this.DrawStatistics(pnl, this._g, data);
            txtOut.AppendText($"{orn}: {s} steps to achieve 1\r\n");
        }

        private void bar_Scroll(object sender, EventArgs e)
        {
            drawTimer.Interval = bar.Value == 0 ? 1 : bar.Value;
        }
    }
}
