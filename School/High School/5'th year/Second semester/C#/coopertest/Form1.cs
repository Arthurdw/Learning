using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coopertest
{
    public partial class Form1 : Form
    {
        int[] afstanden;
        int ingevuld = 0;
        public Form1()
        {
            InitializeComponent();
            Init(new int[8]);
        }

        private void Init(int[] dist)
        {
            afstanden = dist;
            string result = "", extra = "";
            ingevuld = 0;
            for (int i = 0; i < 8; i++)
            {
                result += $"{dist[i]}\r\n";
                ingevuld += dist[i] == 0 ? 1 : 0;
            }
            lblDeelNemer.Text = ingevuld == 8 ? "" : $"Deelnemer {8 - ingevuld}";
            if (ingevuld == 0)
            {
                extra = $"\r\nDe grootste waarde is {afstanden.Max()}. Dat was deelnemer: {afstanden.ToList().IndexOf(afstanden.Max()) + 1}";
                btnNext.Enabled = false;
            } else btnNext.Enabled = true;
            txtResult.Text = $"Afstanden:\r\n{result}\r\nNog {ingevuld} niet ingevuld.{extra}";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                afstanden[8 - ingevuld] = int.Parse(txtAfstand.Text);
            }
            catch (FormatException)
            {
                txtResult.Text = $"De invoer \"{txtAfstand.Text}\" is een ongeldige invoer.";
            }
            Init(afstanden);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Init(new int[8]);
        }
    }
}
