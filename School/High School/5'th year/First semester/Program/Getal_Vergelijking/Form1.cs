// ©Arthurdw (Arthur De Witte)

// Generate a random number, let the user input a number.
// Check if the user its number is < = > to the random number.
// Display this, and show if the number is even or not and show the difference between the numbers.
using System;
using System.Windows.Forms;

namespace Getal_Vergelijking {
    public partial class window : Form {
        public window() {InitializeComponent();}

        private void Btn_check_Click(object sender, EventArgs e) {
            // Declare variables
            Random rn = new Random();
            int Inserted = int.Parse(txtnumb.Text);
            int Generated = rn.Next(1, 101);

            // Check if number is eaqual, higher or lower than the generated one.
            if (Inserted == Generated) {
                lbl_bigger.Text = Inserted.ToString() + " = " + Generated.ToString();
            } else if (Inserted > Generated) {
                lbl_bigger.Text = Inserted.ToString() + " > " + Generated.ToString();
            } else {
                lbl_bigger.Text = Inserted.ToString() + " < " + Generated.ToString();
            }

            // Find and show the difference.
            lbl_difference.Text = "Verschil: " + (Generated - Inserted).ToString();

            // Check is the number is even or odd.
            if ((Generated-Inserted)%2 == 0) {
                lbl_even.Text = "Even: Ja";
            } else {
                lbl_even.Text = "Even: Nee";
            }
        }
    }
}
