using System;
using System.Windows.Forms;

namespace Fibonatchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Declare + read
            ulong fibonacciFirst = 1;
            ulong fibonacciSecond = 1;
            ulong fibonacciFinal = 0;

            // Write
            txtFibo.Text += fibonacciFirst + "\t" + fibonacciSecond + "\t";

            for (int i = 0; i < 18; i++)
            {
                fibonacciFinal = fibonacciFirst + fibonacciSecond;
                fibonacciSecond = fibonacciFirst;
                fibonacciFirst = fibonacciFinal;
                txtFibo.Text += fibonacciFinal + "\t";
            }
        }
    }
}
