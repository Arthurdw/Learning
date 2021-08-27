// ©Arthurdw (Arthur De Witte)

// Project created for GO-AO (Go Atheneum Oudenaarde)
// Project idea:
//      Rock paper scissors. (in dutch)
//      Requirements:
//          - Should be able to do multiplayer.
//          - Should be able to play against bot. (singleplayer)
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BladSteenSchaar {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
            this.Size = new Size(homeSizeWidth, homeSizeHeight);
        }
        int playSizeWidth = 600;
        int playSizeHeight = 210;
        int playErrorSizeWidth = 600;
        int playErrorSizeHeight = 277;
        int playOutputSizeWidth = 600;
        int playOutputSizeHeight = 244;
        int homeSizeWidth = 438;
        int homeSizeHeight = 156;
        bool multiplayer, sp1blad, sp1steen, sp1schaar, sp2blad, sp2steen, sp2schaar;

        // Let the user select between multiplayer or singleplayer.
        private void Btn_Singleplayer_Click(object sender, EventArgs e) {
            Start();
            multiplayer = gb_sp2.Enabled = false;
            this.Text = "Blad Steen Schaar | Singleplayer";
        }

        private void Btn_Multiplayer_Click(object sender, EventArgs e) {
            Start();
            multiplayer = gb_sp2.Enabled = true;
            this.Text = "Blad Steen Schaar | Multiplayer";
        }

        // Start the game itself.
        private void Btn_start_Click(object sender, EventArgs e) {
            this.Size = new Size(homeSizeWidth, homeSizeHeight);
            sp1blad = sp1schaar = sp1steen = sp2blad = sp2schaar = sp2steen = false;
            lbl_error.Text = lbl_out.Text = string.Empty;
            if (rb_1_sp1.Checked)
                sp1blad = rb_1_sp1.Checked;
            if (rb_2_sp1.Checked)
                sp1steen = rb_2_sp1.Checked;
            if (rb_3_sp1.Checked)
                sp1schaar = rb_3_sp1.Checked;
            if (!multiplayer) {
                Random rn = new Random();
                switch (rn.Next(1, 4)) {
                    case 1:
                        rb_1_sp2.Checked = true;
                        break;
                    case 2:
                        rb_2_sp2.Checked = true;
                        break;
                    case 3:
                        rb_3_sp2.Checked = true;
                        break;
                }
            }
            if (rb_1_sp2.Checked)
                sp2blad = rb_1_sp2.Checked;
            if (rb_2_sp2.Checked)
                sp2steen = rb_2_sp2.Checked;
            if (rb_3_sp2.Checked)
                sp2schaar = rb_3_sp2.Checked;
            bool player1notentered = !(sp1blad || sp1steen || sp1schaar);
            bool player2notentered = !(sp2blad || sp2steen || sp2schaar);
            bool player1and2same = (sp1blad == true && sp2blad == true) || (sp1steen == true && sp2steen == true) || (sp1schaar == true && sp2schaar == true);
            if (player1notentered && player2notentered) {
                Error();
                lbl_error.Text = "Speler 1 noch speler 2 heeft iets geselecteerd!";
            } else if (player1notentered) {
                Error();
                lbl_error.Text = "Speler 1 heeft niks geselecteerd!";
            } else if (player2notentered) {
                Error();
                lbl_error.Text = "Speler 2 heeft niks geselecteerd!";
            } else if (player1and2same) {
                this.Size = new Size(playOutputSizeWidth, playOutputSizeHeight);
                lbl_out.Text = "Geen winnaar, beide teams hebben hetzelvde!";
            } else if ((sp1blad && sp2steen) || (sp1steen && sp2schaar) || (sp1steen && sp2schaar)) {
                this.Size = new Size(playOutputSizeWidth, playOutputSizeHeight);
                lbl_out.Text = "Speler 1 heeft gewonnen!";
            } else {
                this.Size = new Size(playOutputSizeWidth, playOutputSizeHeight);
                lbl_out.Text = "Speler 2 heeft gewonnen!";
            }
        }

        // Home Button.
        private void Button1_Click(object sender, EventArgs e) {
            gb_sp1.Location = new Point(19, 140);
            gb_sp2.Location = new Point(225, 146);
            this.Size = new Size(homeSizeWidth, homeSizeHeight);
            btn_Singleplayer.Visible = btn_Multiplayer.Visible = btn_Singleplayer.Enabled = btn_Multiplayer.Enabled = true;
            this.Text = "Blad Steen Schaar";
            this.CenterToScreen();
        }

        // When an error should show up.
        private void Error() {
            lbl_error.BackColor = Color.Red;
            lbl_error.ForeColor = Color.White;
            this.Size = new Size(playErrorSizeWidth, playErrorSizeHeight);
        }

        // Start the game.
        private void Start() {
            gb_sp2.Enabled = true;
            gb_sp1.Location = new Point(12, 12);
            gb_sp2.Location = new Point(218, 12);
            this.Size = new Size(playSizeWidth, playSizeHeight);
            rb_1_sp1.Checked = rb_1_sp2.Checked = rb_2_sp1.Checked = rb_2_sp2.Checked = rb_3_sp1.Checked = rb_3_sp2.Checked = false;
            btn_Singleplayer.Visible = btn_Multiplayer.Visible = btn_Singleplayer.Enabled = btn_Multiplayer.Enabled = false;
            this.CenterToScreen();
        }
    }
}