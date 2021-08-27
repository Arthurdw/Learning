// ©Arthurdw (Arthur De Witte)

// A date checker that will show the season for the date.
// You'll be able to select your location. (north our south)
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Window default setup
namespace Seasons {
    public partial class Seasons:Form {
        // Declare global VAR.
        bool noord = true;
        public Seasons() {InitializeComponent();}
        // When an date value has changed, execute this:
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e) {
            // Declare local VARS.
            int month = dtp_date.Value.Month;
            int day = dtp_date.Value.Day;

            // Check if its the nord our south side.
            if (noord) {
                if (((month == 4) || (month == 5)) || (month == 3 && day >= 21) || (month == 6 && day <= 20)) { // Check if the month is between March and June. (Spring)
                    ptb_main.Image = Image.FromFile("assets/spring.jpg");
                } else if (((month == 7) || (month == 8)) || (month == 6 && day >= 21) || (month == 9 && day <= 20)) { // Check if the month is between June and September. (Summer)
                    ptb_main.Image = Image.FromFile("assets/summer.jpg");
                } else if (((month == 10) || (month == 11)) || (month == 9 && day >= 21) || (month == 12 && day <= 20)) { // Check if the month is between September and December. (Autumn)
                    ptb_main.Image = Image.FromFile("assets/autumn.jpg");
                } else { ptb_main.Image = Image.FromFile("assets/winter.jpg"); // Since everything else passed, we are able to set the last one to Winter
                }
            } else {
                if (((month == 10) || (month == 11)) || (month == 9 && day >= 21) || (month == 12 && day <= 20)) { // Check if the month is between September and December. (Spring)
                    ptb_main.Image = Image.FromFile("assets/spring.jpg");
                } else if (((month == 4) || (month == 5)) || (month == 3 && day >= 21) || (month == 6 && day <= 20)) { // Check if the month is between September and December. (Autumn)
                    ptb_main.Image = Image.FromFile("assets/autumn.jpg");
                } else if (((month == 7) || (month == 8)) || (month == 6 && day >= 21) || (month == 9 && day <= 20)) { // Check if the month is between June and September. (Winter)
                    ptb_main.Image = Image.FromFile("assets/winter.jpg");
                } else { ptb_main.Image = Image.FromFile("assets/summer.jpg"); // Since everything else passed, we are able to set the last one to summer
                }
            }
        }

        // Set North side as active
        private void Btn_north_Click(object sender, EventArgs e) {
            // Only update if South is selected.
            if (!noord) {
                noord = true;
                // Update the button
                btn_north.BackColor = ColorTranslator.FromHtml("#44f6fc");
                btn_north.ForeColor = Color.Black;
                btn_south.BackColor = ColorTranslator.FromHtml("#191919");
                btn_south.ForeColor = Color.White;

                // Update the function.

                // Declare local VARS.
                int month = dtp_date.Value.Month;
                int day = dtp_date.Value.Day;

                // Check if its the nord our south side.
                if (noord) {
                    if (((month == 4) || (month == 5)) || (month == 3 && day >= 21) || (month == 6 && day <= 20)) { // Check if the month is between March and June. (Spring)
                        ptb_main.Image = Image.FromFile("assets/spring.jpg");
                    } else if (((month == 7) || (month == 8)) || (month == 6 && day >= 21) || (month == 9 && day <= 20)) { // Check if the month is between June and September. (Summer)
                        ptb_main.Image = Image.FromFile("assets/summer.jpg");
                    } else if (((month == 10) || (month == 11)) || (month == 9 && day >= 21) || (month == 12 && day <= 20)) { // Check if the month is between September and December. (Autumn)
                        ptb_main.Image = Image.FromFile("assets/autumn.jpg");
                    } else {
                        ptb_main.Image = Image.FromFile("assets/winter.jpg"); // Since everything else passed, we are able to set the last one to Winter
                    }
                } else {
                    if (((month == 10) || (month == 11)) || (month == 9 && day >= 21) || (month == 12 && day <= 20)) { // Check if the month is between September and December. (Spring)
                        ptb_main.Image = Image.FromFile("assets/spring.jpg");
                    } else if (((month == 4) || (month == 5)) || (month == 3 && day >= 21) || (month == 6 && day <= 20)) { // Check if the month is between September and December. (Autumn)
                        ptb_main.Image = Image.FromFile("assets/autumn.jpg");
                    } else if (((month == 7) || (month == 8)) || (month == 6 && day >= 21) || (month == 9 && day <= 20)) { // Check if the month is between June and September. (Winter)
                        ptb_main.Image = Image.FromFile("assets/winter.jpg");
                    } else {
                        ptb_main.Image = Image.FromFile("assets/summer.jpg"); // Since everything else passed, we are able to set the last one to summer
                    }
                }
            }
        }

        // Set South side as active
        private void Btn_south_Click(object sender, EventArgs e) {
            // Only update if North is selected.
            if (noord) {
                noord = false;
                // Update the button
                btn_north.BackColor = ColorTranslator.FromHtml("#191919");
                btn_north.ForeColor = Color.White;
                btn_south.BackColor = ColorTranslator.FromHtml("#44f6fc");
                btn_south.ForeColor = Color.Black;

                // Update the function.

                // Declare local VARS.
                int month = dtp_date.Value.Month;
                int day = dtp_date.Value.Day;

                // Check if its the nord our south side.
                if (noord) {
                    if (((month == 4) || (month == 5)) || (month == 3 && day >= 21) || (month == 6 && day <= 20)) { // Check if the month is between March and June. (Spring)
                        ptb_main.Image = Image.FromFile("assets/spring.jpg");
                    } else if (((month == 7) || (month == 8)) || (month == 6 && day >= 21) || (month == 9 && day <= 20)) { // Check if the month is between June and September. (Summer)
                        ptb_main.Image = Image.FromFile("assets/summer.jpg");
                    } else if (((month == 10) || (month == 11)) || (month == 9 && day >= 21) || (month == 12 && day <= 20)) { // Check if the month is between September and December. (Autumn)
                        ptb_main.Image = Image.FromFile("assets/autumn.jpg");
                    } else {
                        ptb_main.Image = Image.FromFile("assets/winter.jpg"); // Since everything else passed, we are able to set the last one to Winter
                    }
                } else {
                    if (((month == 10) || (month == 11)) || (month == 9 && day >= 21) || (month == 12 && day <= 20)) { // Check if the month is between September and December. (Spring)
                        ptb_main.Image = Image.FromFile("assets/spring.jpg");
                    } else if (((month == 4) || (month == 5)) || (month == 3 && day >= 21) || (month == 6 && day <= 20)) { // Check if the month is between September and December. (Autumn)
                        ptb_main.Image = Image.FromFile("assets/autumn.jpg");
                    } else if (((month == 7) || (month == 8)) || (month == 6 && day >= 21) || (month == 9 && day <= 20)) { // Check if the month is between June and September. (Winter)
                        ptb_main.Image = Image.FromFile("assets/winter.jpg");
                    } else {
                        ptb_main.Image = Image.FromFile("assets/summer.jpg"); // Since everything else passed, we are able to set the last one to summer
                    }
                }
            }
        }
    }
}
