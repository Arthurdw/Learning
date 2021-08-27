using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        DateTime tijd = new DateTime(1, 1, 1, 0, 0, 0);
        Random rn = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrGeneral.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrGeneral.Stop();
        }

        private void tmrGeneral_Tick(object sender, EventArgs e)
        {
            tijd = tijd.AddMilliseconds(10);
            lblTijdTeller.Text = tijd.ToString("HH:mm:ss.fff");
            lblTijdNu.Text = DateTime.Now.ToString("ddd, dd-MMM-yyyy HH:mm:ss.fff");
            if (tijd.Second % 2 == 0 && tijd.Millisecond == 0) ChangeColor();
        }

        private void ChangeColor()
        {
            int r = rn.Next(0, 255),
                g = rn.Next(0, 255),
                b = rn.Next(0, 255);
            this.BackColor = Color.FromArgb(255, r, g, b);
        }
    }
}
