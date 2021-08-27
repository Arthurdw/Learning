using System;
using System.Windows.Forms;

namespace TekstLus1
{
    public partial class Fill : Form
    {
        public Fill()
        {
            InitializeComponent();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            txtFill.Clear();
            for (int i = 0; i < 28; i++)
            {
                txtFill.Text += "| 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |\r\n";
            }
        }
    }
}
