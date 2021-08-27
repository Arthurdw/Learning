// ©Arthurdw (Arthur De Witte)

// A program that will display 3 random pictures from the assets folder.
// Results:
//      When 3 equal images have been taken, the text will say "Jackpot"!
//      When 2 equal images have been taken, the text will say "Bijna goed"!
//      When 3 different images have been taken, the text will say "Speel opnieuw"!
using System;
using System.Drawing;
using System.Windows.Forms;

namespace afbeeldingen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Declare vars
        bool started = false;
        int img1, img2, img3;
        int FormSizeWidth = 748;
        int FormSizeHeight = 343;
        Random RNBase = new Random();


        // When the button gets pressed!
        private void Btn_play_Click(object sender, EventArgs e) {
            // Check if the game has already started.
            if (!started) {
                this.Size = new Size(FormSizeWidth, FormSizeHeight);
                started = true;
            }
            // Get 3 random numbers and apply the pictureboxes to them.
            img1 = RNBase.Next(1, 4);
            ptb_1.Image = Image.FromFile("assets/" + img1 + ".jpg");
            img2 = RNBase.Next(1, 4);
            ptb_2.Image = Image.FromFile("assets/" + img2 + ".jpg");
            img3 = RNBase.Next(1, 4);
            ptb_3.Image = Image.FromFile("assets/" + img3 + ".jpg");
            // Check if the 3 boxes are equal (if), double (elif) or if none are equal (else).
            if (img1 == img2 && img2 == img3 && img1 == img3) {
                lbl_out.Text = "Jackpot!";
            } else if ((img1 == img2) || (img2 == img3) || (img1 == img3)) {
                lbl_out.Text = "Bijna goed!";
            } else {
                lbl_out.Text = "Speel opnieuw";
            }
        }
    }
}
