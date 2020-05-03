using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timers
{
    public partial class Form1 : Form
    {
        int timerTel;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            timerTel = 1;
        }

        private void tmrConsole_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(timerTel);
            timerTel++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrConsole.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrConsole.Stop();
            Init();
        }
    }
}
