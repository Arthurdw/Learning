// ©Arthurdw | GO-AO 2019

// Simple validation tool for numbers.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GetalCheck
{
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();

            // Default background image:
            pbRes.Image = Image.FromFile("media/logo.png");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // Basis declaratie:
            int number = 0;

            // Foute invoer:
            try
            {
                number = int.Parse(txtinvoer.Text);
            }
            catch (System.FormatException)
            {
                pbRes.Image = Image.FromFile("media/denied.jpg");
                return;
            }
            if ((number.ToString()).Length != 5) pbRes.Image = Image.FromFile("media/wrong.jpg");
            else if (number % 2 == 0) pbRes.Image = Image.FromFile("media/yinyang.png");
            else
            {
                bool allowed = true;
                for (int i = 0; i < 5; i++)
                {
                    // Check if the number is not equal to [1, 4, 7, 9]:
                    if (!(number.ToString().Substring(i, 1).Equals("1") || number.ToString().Substring(i, 1).Equals("4") || number.ToString().Substring(i, 1).Equals("7") || number.ToString().Substring(i, 1).Equals("9"))) allowed = false;
                }
                if (allowed) pbRes.Image = Image.FromFile("media/happy.jpg");
                if (!allowed) pbRes.Image = Image.FromFile("media/sad.jpg");
            }
        }
    }
}