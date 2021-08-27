using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poxedex
{
    public partial class Form1 : Form
    {
        int afbNumr;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            afbNumr = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (afbNumr == 13) Init();
            else
            {
                Image img = Image.FromFile($"pokes/{afbNumr}.jpg");
                ptbAfb.BackgroundImage = img;
                afbNumr++;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Init();
        }
    }
}
