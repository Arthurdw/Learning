// ©Arthurdw (Arthur de Witte)

// Created for GO-AO | Informatics
// You will be able to calculate the bacteria if they would raise in a linear form.
// Inserted values will be: Start hour, End hour, Start amount of bacteria & End amount of bacteria.
using System;
using System.Windows.Forms;

namespace Bacterien
{
    public partial class Bacterien : Form
    {
        // Declare items.
        double startHour, endHour, startAmountBacs, endAmountBacs;

        public Bacterien()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            // Lets first clear the text box to prevent unwanted text stacking.
            txtResult.Clear();


            // Read items.
            try
            {
                startHour = double.Parse(txtStartUur.Text);
                endHour = double.Parse(txtEindUur.Text);
                startAmountBacs = double.Parse(txtAantalBactStart.Text);
                endAmountBacs = double.Parse(txtAantalBactEinde.Text);
            }
            catch (Exception)
            {
                txtResult.Text = "Invalid input, received an error!";
                return;
            }

            // Lets do the math here & lets display it.
            double growfactor, bacsPerHour, totalCurrent;
            growfactor = endHour - startHour;
            bacsPerHour = (endAmountBacs - startAmountBacs)/ growfactor;
            totalCurrent = startAmountBacs;
            txtResult.Text += "VERLOOP VAN DE GROEICULTUUR:" + Environment.NewLine;

            for (int i = 0; i <= 24; i++)
            {
                txtResult.Text += i + ":00\t:" + totalCurrent.ToString(".0") + Environment.NewLine;
                if (i != 24)
                {
                    txtResult.Text += i + ":30\t:" + (totalCurrent + bacsPerHour / 2).ToString(".0") + Environment.NewLine;
                }
                totalCurrent += bacsPerHour;
            }
            txtResult.Text += "Na 24 uur bedraagt de totale cultuur: " + (totalCurrent - bacsPerHour).ToString(".0");

        }
    }
}
