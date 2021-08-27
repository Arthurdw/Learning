// ©Arthurdw (Arthur De Witte)

// Select your birthdate with a datepicker.
// See how old you would be in 2020. 
// Show an image related to your age.
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lottery {
    public partial class Form1 : Form {
        public Form1() {InitializeComponent();}

        private void Btn_submit_Click(object sender, EventArgs e) {
            // Declair VARS, and assign some values.
            int year = dtp_birthday.Value.Year;
            int month = dtp_birthday.Value.Month;
            int age_2020 = 2020 - year;

            // Calc age in 2020.
            lbl_age.Text = age_2020.ToString() + " jaar!";

            // Checks and update for the image.
            if (age_2020 > 95) { ptb_image.Image = Image.FromFile("skeleton.jpg");
            } else if (Enumerable.Range(50, 96).Contains(age_2020)) { ptb_image.Image = Image.FromFile("breien.jpg");
            } else if (Enumerable.Range(10, 51).Contains(age_2020)) { ptb_image.Image = Image.FromFile("sport.jpg");
            } else { ptb_image.Image = Image.FromFile("baby.jpg"); }

            // Checks and update for the bonus.
            if ((age_2020 % 5 == 0) && ((age_2020 * 12 + month) % 2 == 0)) {lbl_bonus.Text = "50.00 euro.";
            } else if (age_2020%5 == 0) {lbl_bonus.Text = "50.00 euro.";
            } else if ((age_2020*12+month)%3 == 0) {lbl_bonus.Text = "100.00 euro.";
            } else {lbl_bonus.Text = "00.00 euro.";}

        }
    }
}
