using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KleinsteGrootste
{
    public partial class Form1 : Form
    {
        int biggest, smallest, amountNumbers, sum;
        double average;
        string allNumbers;

        public Form1()
        {
            InitializeComponent();
            biggest = int.MinValue;
            smallest = int.MaxValue;
            amountNumbers = 1;
            average = 1;
            allNumbers = "";
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            int newNumber;
            try
            {
                // Reading numbers.
                newNumber = int.Parse(txtInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input value!", "YEYE U BAD BOY");
                return;
            }
            allNumbers += newNumber + "\t";
            sum += newNumber;
            if (newNumber < smallest) smallest = newNumber;
            if (newNumber > biggest) biggest = newNumber;
            average = (double)sum / (double)amountNumbers;
            ++amountNumbers;
            txtResult.Text = allNumbers + Environment.NewLine +
                "The smallest number: " + smallest + Environment.NewLine +
                "The biggest number: " + biggest + Environment.NewLine +
                "The sum is: " + sum + Environment.NewLine +
                "The average: " + average.ToString("0.00");
            if (amountNumbers == 10)
            {
                biggest = int.MinValue;
                smallest = int.MaxValue;
                amountNumbers = 1;
                average = 1;
                allNumbers = "";
                txtResult.Clear();
            }
        }
    }
}
