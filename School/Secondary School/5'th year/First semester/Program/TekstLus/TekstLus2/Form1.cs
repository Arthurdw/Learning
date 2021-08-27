using System;
using System.Linq;
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
            // Declare + insert
            int amount = 55;
            string _first = String.Concat(Enumerable.Repeat("| 0 ", amount)) + "\r\n";
            string _second = String.Concat(Enumerable.Repeat("0 | ", amount)) + "\r\n";
            string _strike = String.Concat(Enumerable.Repeat("* ", amount*2)) + "\r\n";

            txtFill.Clear();
            for (int i = 1; i < 29; i++)
            {
                if (i%5 == 0) txtFill.Text += _strike;
                else if (i%2 == 0) txtFill.Text += _first;
                else txtFill.Text += _second;
            }
        }
    }
}
