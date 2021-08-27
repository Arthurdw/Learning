using System;
using System.Windows.Forms;

namespace SimulatieDobbelsteen
{
    public partial class Form1 : Form
    {
        int[] simulation, result;
        Random rn = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThrow_Click(object sender, EventArgs e)
        {
            simulation = new int[1000];
            result = new int[6];
            string stringResult = "";
            for (int i = 0; i < 1000; i++)
            {
                int _numb = rn.Next(1, 7);
                simulation[i] = _numb; // Save the number.
                stringResult += $"{i + 1}:{_numb}\t"; // Insert data into result. (String)
                for (int j = 0; j < 6; j++) result[j] += _numb == j + 1 ? 1 : 0; // Add a number to the result array if the number equals to one out of 6
            }
            txtresult.Text = stringResult + "\r\n\r\nAnalyse van de worpen.\r\n\r\n"; // Display stats introduction.
            for (int j = 0; j < 6; j++) txtresult.Text += $"{j + 1} werd {result[j]} keer gegooid.\r\n"; // Display stats text.
        }
    }
}