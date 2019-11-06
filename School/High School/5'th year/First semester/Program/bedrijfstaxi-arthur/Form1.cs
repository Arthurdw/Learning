// Arthur De Witte (Arthurdw)
using System;
using System.Windows.Forms;

namespace bedrijfstaxi_arthur {
    public partial class TAXI : Form {
        public TAXI() {
            InitializeComponent();
        }

        private void Calcbutton_Click(object sender, EventArgs e) {
            // Creating VARS
            int aantalbezoekers = int.Parse(txtbezoekersaantal.Text);
            int passagiers12, passagiers4, passagierslaatste;

            // Calculating cars
            passagiers12 = (aantalbezoekers - (aantalbezoekers%12))/12;
            passagiers4 = ((aantalbezoekers - (passagiers12 * 12)) % 4) + 1;
            passagierslaatste = aantalbezoekers - (passagiers12*12);

            // Displaying Results
            txtbox12.Text = passagiers12.ToString();
            txtbox4.Text = passagiers4.ToString();
            txtboxlaatste.Text = passagierslaatste.ToString();
        }
    }
}
