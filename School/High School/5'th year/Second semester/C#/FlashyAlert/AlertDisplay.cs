using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlashyAlert
{
    public partial class AlertDisplay : Form
    {
        public string message;
        public Image icon;
        public int i;
        public State current;

        public AlertDisplay(string msg, Image ico, int count)
        {
            InitializeComponent();
            message = msg;
            icon = ico;
            i = count;
        }

        public enum State {
            wait, start, close
        }

        private void AlertDisplay_Load(object sender, EventArgs e)
        {
            ptbIcon.BackgroundImage = icon;
            label1.Text = message;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height * i);
            current = State.start;
            FadeTimer.Start();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Form1.CloseForm(this);
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            switch (current)
            {
                case State.start:
                    FadeTimer.Interval = 25;
                    Opacity += 0.1;
                    if (Opacity == 1) current = State.wait;
                    break;
                case State.wait:
                    FadeTimer.Interval = 2000;
                    current = State.close;
                    break;
                case State.close:
                    FadeTimer.Interval = 50;
                    Opacity -= 0.1;
                    if (Opacity == 0) Form1.CloseForm(this);
                    break;
            }
        }
    }
}
