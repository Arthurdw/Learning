using System;
using System.Windows.Forms;

namespace LoonBerekenen
{
    public partial class Loonberekenen : Form
    {
        // Declareer.
        double uurLoon, aantalUur, basis;

        public Loonberekenen()
        {
            InitializeComponent();
        }

        private void TSMIGewoon_Click(object sender, EventArgs e)
        {
            if (Inlezen("Gewoon Loon")) txtLoon.Text = (basis).ToString("#.00-euro");
        }

        private void TSMINacht_Click(object sender, EventArgs e)
        {
            if (Inlezen("Nacht Loon")) txtLoon.Text = (basis * 1.5).ToString("#.00-euro");
        }

        private void TSMIVerplaatsing_Click(object sender, EventArgs e)
        {
            if (Inlezen("Gewoon Loon + Verplaatsing")) txtLoon.Text = (basis + 12).ToString("#.00-euro");
        }

        private void TSMIWeekend_Click(object sender, EventArgs e)
        {
            if (Inlezen("Weekend Loon")) txtLoon.Text = (basis * 2).ToString("#.00-euro");
        }

        private bool Inlezen(string status)
        {
            bool success = true;
            try
            {
                uurLoon = double.Parse(txtUurloon.Text);
                aantalUur = double.Parse(txtAantal.Text);
                basis = uurLoon * aantalUur;
                lblStatus.Text = status;
            }
            catch (System.FormatException)
            {
                txtLoon.Text = "Fout invoer.";
                lblStatus.Text = "(status)";
                success = false;
            }
            return success;
        }
    }
}
