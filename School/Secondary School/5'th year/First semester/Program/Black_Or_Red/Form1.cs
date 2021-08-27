// ©Arthurdw (Arthur De Witte)

// Insert the total amount you want to use in the game.
// Be able to insert your bet and choose a color. (RED/BLACK)
// The winning side wil show after 3 seconds. 
// If you win, your bet will double and be added to your current balance.
// But if you lose you'll lose your bet. :)

// Chances:
//  50/50 on base of 0-100.
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Black_Or_Red {
    public partial class Black_Red:Form {
        // Declare VARS.
        int AmountLeft, GameInput;
        bool started = false;
        readonly Random rn = new Random();
        public Black_Red() {InitializeComponent();}
        private void Btn_NewGame_Click(object sender, EventArgs e) {
            // Assign value to the amount VAR.
            AmountLeft = int.Parse(txt_StartAmount.Text);
            // Check if the inserted amount was minimum 100. (so 100 is fine)
            if (AmountLeft < 100) {
                // Popup the error. :)
                lbl_error.Text = "De minimum inzet is 100.";
                txt_StartAmount.Text = "ERROR";
                lbl_Amount.Text = "     <resterend bedrag>";
            } else {
                // Update fields to show that the game has started.
                lbl_error.Text = "";
                lbl_Amount.Text = "Je kan nog " + AmountLeft + " inzetten!";
                txt_Input.Text = "";
                // Allow the RED and BLACK button to be used.
                started = true;
            }
        }

        // Black Button
        private void Btn_Black_Click(object sender, EventArgs e) {
            // Check if the game has started.
            if (!started) {
                // If the game hasn't started yet, return an error.
                lbl_error.Text = "Maak eerst een nieuw spel.";
                txt_StartAmount.Text = "ERROR";
                lbl_Amount.Text = "     <resterend bedrag>";
            } else {
                // Check if the user has enough money.
                if (GameInput > AmountLeft) {
                    lbl_error.Text = "Je bent zo rijk niet.";
                } else {
                    // Generate a random number.
                    int random_numb = rn.Next(0, 101);
                    // Check if the random number is between 0-50.
                    if (Enumerable.Range(0, 51).Contains(random_numb)) {
                        // If the number is between 0-50, the player has won.
                        // So update the button its color and multiply the user its balance after 3 seconds.
                        System.Threading.Thread.Sleep(3000);
                        btn_Result.BackColor = Color.Black;
                        AmountLeft += GameInput;
                        lbl_Amount.Text = "Je kan nog " + AmountLeft + " inzetten!";
                    } else {
                        // The number isn't between 0-50, so the player lost. :(
                        // Update the color and remove the bet from the user its balance.
                        System.Threading.Thread.Sleep(3000);
                        btn_Result.BackColor = Color.Red;
                        AmountLeft -= GameInput;
                        lbl_Amount.Text = "Je kan nog " + AmountLeft + " inzetten!";
                    }
                }
            }
        }

        // Red Button
        private void Btn_rood_Click(object sender, EventArgs e) {
            // Check if the game has started.
            if (!started) {
                // If the game hasn't started yet, return an error.
                lbl_error.Text = "Maak eerst een nieuw spel.";
                txt_StartAmount.Text = "ERROR";
                lbl_Amount.Text = "     <resterend bedrag>";
            } else {
                // Check if the user has enough money.
                GameInput = int.Parse(txt_Input.Text);
                if (GameInput > AmountLeft) {
                    lbl_error.Text = "Je bent zo rijk niet.";
                } else {
                    // Generate a random number.
                    int random_numb = rn.Next(0, 101);
                    // Check if the random number is between 0-50.
                    if (Enumerable.Range(0, 51).Contains(random_numb)) {
                        // If the number is between 0-50, the player has won.
                        // So update the button its color and multiply the user its balance after 3 seconds.
                        System.Threading.Thread.Sleep(3000);
                        btn_Result.BackColor = Color.Red;
                        AmountLeft += GameInput;
                        lbl_Amount.Text = "Je kan nog " + AmountLeft + " inzetten!";
                    } else {
                        // The number isn't between 0-50, so the player lost. :(
                        // Update the color and remove the bet from the user its balance.
                        System.Threading.Thread.Sleep(3000);
                        btn_Result.BackColor = Color.Black;
                        AmountLeft -= GameInput;
                        lbl_Amount.Text = "Je kan nog " + AmountLeft + " inzetten!";
                    }
                }
            }
        }
    }
}
