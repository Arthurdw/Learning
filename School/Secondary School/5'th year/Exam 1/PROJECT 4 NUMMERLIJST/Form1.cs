// ©Arthurdw | GO-AO 2019

// Number analiser program should list all given numbers!

using System;
using System.Windows.Forms;

namespace PROJECT_4_NUMMERLIJST
{
    public partial class NumberAnalizer : Form
    {
        // Default "customization" variables:
        string sentenceInsertedNumbers = "Lijst van ingevoerde getallen:" + Environment.NewLine + Environment.NewLine;
        string sentenceReverseNumbers = "Lijst van de omgekeerde getallen:" + Environment.NewLine + Environment.NewLine;
        string sentenceButton = "Klik op de knop 'Toon lijst' om de samenvatting te zien!" + Environment.NewLine + Environment.NewLine;

        // Global saved vars:
        string insertedParams = "";
        string reversedParams = "";
        int biggestNumb = int.MinValue;
        int smallestNumb = int.MaxValue;
        int counter = 0;
        int total = 0;
        DateTime firstClick;
        DateTime secondClick;
        bool firstClickAchieved = false;
        bool SecondClickAchieved = false;

        public NumberAnalizer()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (firstClickAchieved)
            {
                if (!(SecondClickAchieved))
                {
                    secondClick = DateTime.Now;
                    SecondClickAchieved = ! SecondClickAchieved;
                }
            }
            else
            {
                firstClick = DateTime.Now;
                firstClickAchieved = !firstClickAchieved;
            }

            // Lets first check if its a number:
            int numb = 0;
            try
            {
                numb = int.Parse(txtInput.Text);
            }
            catch (Exception)
            {
                txtInput.Text = "FOUTE INVOER";
                return;
            }

            // Display and save params.
            insertedParams += numb.ToString() + "\t";
            txtResult.Text = sentenceInsertedNumbers + insertedParams + Environment.NewLine + Environment.NewLine;

            // Reverse parameters:
            string primaryParam = "";
            string reversed = "";
            for (int i = 0; i < numb.ToString().Length; i++)
            {
                if (numb.ToString().Substring(i, 1) == "-") primaryParam = "-";
                else reversed = numb.ToString().Substring(i, 1) + reversed; 
            }
            reversedParams += primaryParam + reversed + "\t";

            // Display reversed parameters & final line:
            txtResult.Text += sentenceReverseNumbers + reversedParams + Environment.NewLine + Environment.NewLine;
            txtResult.Text += sentenceButton;

            // Statistics:
            if (numb > biggestNumb) biggestNumb = numb;
            if (int.Parse(primaryParam + reversed) > biggestNumb) biggestNumb = int.Parse(primaryParam + reversed);
            if (numb < smallestNumb) smallestNumb = numb;
            if (int.Parse(primaryParam + reversed) < smallestNumb) smallestNumb = int.Parse(primaryParam + reversed);
            total += numb + int.Parse(primaryParam + reversed);
            ++counter;

            // Prepare for next input:
            txtInput.Clear();
            txtInput.Focus();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            // You have to have inserted atleast something:
            if (counter < 2)
            {
                txtInput.Text = "Geef eerst tenminste 2 waarden voor je statistieken wilt!";
                return;
            }
            // Display stats:
            txtResult.Text += Environment.NewLine + "SAMENVATTING:" + Environment.NewLine;
            txtResult.Text += "Je hebt " + counter + "getallen ingevoerd." + Environment.NewLine + Environment.NewLine;
            txtResult.Text += "Het grootste getal is: " + biggestNumb.ToString() + Environment.NewLine;
            txtResult.Text += "Het kleinste getal is: " + smallestNumb.ToString() + Environment.NewLine;
            txtResult.Text += "Het gemiddelde bedraagt: " + (total / counter).ToString() + Environment.NewLine;
            txtResult.Text += "Het aantal seconden tussen je eerste en je 2de klik bedraagd: " + (secondClick - firstClick).Seconds.ToString("0000") + "," + (secondClick - firstClick).Seconds + " SEC/MILLISEC" + Environment.NewLine;
            ulong calc = (ulong)Math.Sqrt(((double)total / (double)counter))/4;
            while (calc > 12)
            {
                calc = calc / 2;
            }
            string monthDesc = "";
            switch (calc)
            {
                case 1:
                    monthDesc = "Start to party-maand";
                    break;
                case 2:
                    monthDesc = "Start to love-maand";
                    break;
                case 3:
                    monthDesc = "Start to Spring-maand";
                    break;
                case 5:
                    monthDesc = "Start to sparkle-maand";
                    break;
                case 9:
                    monthDesc = "Start to learn-maand";
                    break;
                case 10:
                    monthDesc = "Start to Fitness-maand";
                    break;
                case 12:
                    monthDesc = "Start to Eat Sweets-maand";
                    break;
                default:
                    monthDesc = "Start to Enjoy the Little things-maand";
                    break;
            }
            txtResult.Text += "De rekenkundige bewerking (van 0 tot 12) met het gemiddelde berekende de maand: " + calc + ": " + monthDesc;
        }
    }
}
