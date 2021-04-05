using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Balletjes
{
    public partial class Form1 : Form
    {
        private Random _rn;
        private double _size;

        public Form1()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void InitializeProgram()
        {
            Ballz.lastId = 0;
            Ballz.All = new List<Ballz>();
            Ballz.collisionDetected = this.SpawnRandomBall;
            GraphicsHandler.panel = panel;
            GraphicsHandler.graphic = panel.CreateGraphics();
            GraphicsHandler.graphic.SmoothingMode = SmoothingMode.AntiAlias;

            // Prevent flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
                // Bitwise operation to set properties
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,

                // Lets bind it to our panel and our form.
                null, panel, new object[] { true });
            _rn = new Random();
            _size = 40;
        }

        private void AddBall(Point location)
        {
            Ballz.All.Add(new Ballz(location, Color.FromArgb(_rn.Next(256), _rn.Next(256), _rn.Next(256)), Convert.ToInt32(_size)));
            if (_size > 4) _size -= 0.1;
        }

        private void HandlePaintClick(object sender, MouseEventArgs e)
        {
            if (Ballz.All.Count == 0)
            {
                AddBall(e.Location);
                SpawnRandomBall();
                panel.Invalidate();
                drawer.Start();
            }
        }

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            GraphicsHandler.graphic = e.Graphics;
            GraphicsHandler.graphic.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Ballz circle in Ballz.All) circle.Draw();
        }

        private void drawer_Tick(object sender, EventArgs e)
        {
            Ballz[] selected = new Ballz[Ballz.All.Count];
            Ballz.All.CopyTo(selected);
            foreach (Ballz circle in selected) circle.PerformStep();
            panel.Invalidate();
        }

        private void SpawnRandomBall()
            => AddBall(new Point(_rn.Next(panel.Width - Convert.ToInt32(_size)), _rn.Next(panel.Height - Convert.ToInt32(_size))));
    }
}