// ©Arthurdw | Created for GO-AtheneumOudenaarde

// A simple traffic light simulator.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class TrafficLightsSimulator : Form
    {
        Graphics g;
        int ticks;
        bool first;
        bool french;

        public TrafficLightsSimulator()
        {
            InitializeComponent();
            g = PanelLight.CreateGraphics();
            ticks = 0;
            first = false;
            french = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            first = !first;
            french = false;
            ticks = 0;
            ButtonStart.Text = first ? "Stop Lights" : "Start Lights";
            ButtonFrench.Text = "Start French Lights";
            if (first) Timer.Start();
            else Timer.Stop();
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            if (!first)
            {
                Timer.Stop();
                first = false;
                ticks = 0;
                TextCountBox.Text = "";
            }
            DrawLight(Color.Green, Color.Orange, Color.Red);
        }

        private void ButtonFrench_Click(object sender, EventArgs e)
        {
            first = !first;
            french = true;
            ticks = 0;
            ButtonFrench.Text = first ? "Stop Frech Lights" : "Start French Lights";
            ButtonStart.Text = "Start Lights";
            if (first) Timer.Start();
            else Timer.Stop();
        }

        private void PopLight(int index)
        {
            DrawLight(
                index == 0 ? Color.Green : Color.FromArgb(50, Color.Green),
                index == 1 ? Color.Orange : Color.FromArgb(50, Color.Orange),
                index == 2 ? Color.Red : Color.FromArgb(50, Color.Red));
        }


        private void DrawLight(Color green, Color orange, Color red)
        {
            PanelLight.Refresh();
            g.FillEllipse(new SolidBrush(red), 15, 10, 120, 120);
            g.FillEllipse(new SolidBrush(orange), 15, 140, 120, 120);
            g.FillEllipse(new SolidBrush(green), 15, 270, 120, 120);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks < 10) PopLight(2);
            else if (ticks >= 10 && ticks <= 13 && french) PopLight(1);
            else if (ticks >= 10 && ticks <= 20) PopLight(0);
            else if (ticks > 20)
            {
                PopLight(1);
                if (ticks > 23) ticks = 0;
            }
            TextCountBox.Text = ticks.ToString();
        }
    }
}
