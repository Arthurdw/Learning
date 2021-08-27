using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flashing_Label
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rn = new Random();
            Color ForeColor = Color.FromArgb(rn.Next(0, 255), rn.Next(0, 255), rn.Next(0, 255), rn.Next(0, 255));
            label1.ForeColor = button1.ForeColor = textBox1.ForeColor = ForeColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}
