// ©Arthurdw (Arthur De Witte)

// Generate a random time, see if it would be day or night.
// Day times = 07:00-21:00
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace day_nite {
    public partial class Form1 : Form {
        public Form1() {InitializeComponent();}

        private void Btn_gen_Click(object sender, EventArgs e) {
            // Declaring VARS and assigning some values.
            Random rn = new Random();
            int num = rn.Next(0, 1441);
            TimeSpan ts = TimeSpan.FromMinutes(num);

            // Converting the minutes to ´Hour:Minute´ format.
            string formatted_time = new DateTime(ts.Ticks).ToString("HH:mm");

            // Assigning the textbox to the amount of minutes.
            // You will be able to edit this text box but it wont update the output.
            txt_minuten.Text = num.ToString();

            // Check if its day or night.
            if ((num >= 420 && num <= 1260)) {
                // Its day so lets set the time label to some informative text.
                lbl_licht_or_donker.Text = "Tijd: " + formatted_time + " | Licht";

                // Update the image.
                afbeelding.Image = Image.FromFile("d.jpg");
            } else {
                // Its night so lets set the time label to some informative text.
                lbl_licht_or_donker.Text = "Tijd: " + formatted_time + " | Donker";

                // Update the image.
                afbeelding.Image = Image.FromFile("n.jpg");
            }
        }
    }
}
