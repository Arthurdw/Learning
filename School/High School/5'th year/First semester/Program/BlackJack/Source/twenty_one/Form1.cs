// ©Arthurdw (Arthur De Witte)

// Blackjack game.
// On start:
// 2 cards for the host. (2 random numbers between 1 and 13)
// 2 cards for the player.  (2 random numbers between 1 and 13)
// Expand window vieuw to let them see the table.

// When the host plays 16 or less, stop with 17.
// When the player plays bigger than 21, busted.
// When the player plays less than 21, highest score?
// 21 with 2 cards is bet times 3.
// If the player is higher than the host, bet times 2.
// If the player is equal with the host, bet returns. (Bet times 1, so just a return.)
// If the host has a higher score the host wins, so the bet gets lost. (Bet goes practicly to host.)

// Util:
//     Window Start Size: 310; 360
using System;
using System.Drawing;
using System.Windows.Forms;

namespace twenty_one {
    public partial class Twenty_One_App:Form {
        public Twenty_One_App() {InitializeComponent();}
        // Declare VARS
        readonly bool Allowed = true;
        readonly Random RN = new Random();
        int HostRN, UserRN, HostTotal, UserTotal, UserBank, UserBet, count;


        private void Btn_Ok_Click(object sender, EventArgs e) {
            if (count >= 2) {
                ptb_1.Location = new Point(299, 50);
                ptb_2.Location = new Point(490, 50);
            }
            btn_Ok.Enabled = false;
            // If the user clicks ok, go back to the game.
            this.Size = new System.Drawing.Size(310, 360);
            this.BackColor = lbl_inzet.BackColor = lbl_euro.BackColor = lbl_balance.BackColor = Color.ForestGreen;
            lbl_state.Visible = lbl_state.Visible = btn_Ok.Visible = lbl_info.Visible = ptb_3.Visible = ptb_4.Visible = ptb_5.Visible = ptb_6.Visible = ptb_7.Visible = ptb_host_2.Visible = ptb_host_3.Visible = ptb_host_4.Visible = ptb_host_5.Visible = ptb_host_6.Visible = ptb_stack_back.Visible = false;
            ptb_1.Location = new Point(299, 142);
            ptb_2.Location = new Point(490, 142);
            ptb_status.Image = null;
            HostRN = UserRN = HostTotal = UserTotal = count = 0;
            ptb_status.Image = ptb_1.Image = ptb_2.Image = ptb_3.Image = ptb_4.Image = ptb_5.Image = ptb_6.Image = ptb_7.Image = ptb_host_1.Image = ptb_host_2.Image = ptb_host_3.Image = ptb_host_4.Image = ptb_host_5.Image = ptb_host_6.Image = ptb_host_7.Image = null;
            btn_start.BackColor = Color.Lime;
            btn_start.FlatAppearance.MouseOverBackColor = btn_start.FlatAppearance.MouseDownBackColor = btn_start.BackColor;
            ptb_host_1.Visible = ptb_1.Visible = ptb_2.Visible = ptb_stack_back.Visible = btn_start.Enabled = true;
            this.CenterToScreen();
        }

        private void Btn_stand_Click(object sender, EventArgs e) {
            UserBet = int.Parse(txt_inzet.Text);
            this.CenterToScreen();
            // Stand
            switch (count) {
                case 2:
                    HostTotal += RN.Next(1, 14);
                    ptb_host_5.Visible = ptb_3.Visible = true;
                    ptb_host_5.Image = Image.FromFile("assets/back_blue.png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_3.Image = Image.FromFile("assets/" + UserRN + ".png");
                    count++;
                    break;
                case 3:
                    HostTotal += RN.Next(1, 14);
                    ptb_host_4.Visible = ptb_4.Visible = true;
                    ptb_host_4.Image = Image.FromFile("assets/back_blue.png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_4.Image = Image.FromFile("assets/" + UserRN + ".png");
                    count++;
                    break;
                case 4:
                    HostTotal += RN.Next(1, 14);
                    ptb_host_3.Visible = ptb_5.Visible = true;
                    ptb_host_3.Image = Image.FromFile("assets/back_blue.png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_5.Image = Image.FromFile("assets/" + UserRN + ".png");
                    count++;
                    break;
                case 5:
                    HostTotal += RN.Next(1, 14);
                    ptb_host_2.Visible = ptb_6.Visible = true;
                    ptb_host_2.Image = Image.FromFile("assets/back_blue.png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_6.Image = Image.FromFile("assets/" + UserRN + ".png");
                    count++;
                    break;
                case 6:
                    HostTotal += RN.Next(1, 14);
                    ptb_host_7.Visible = ptb_7.Visible = true;
                    ptb_host_7.Image = Image.FromFile("assets/back_blue.png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_7.Image = Image.FromFile("assets/" + UserRN + ".png");
                    count++;
                    break;
            }
            // If the total is already over 17, the host will hit.
            if (HostTotal >= 17) {
                // Hit screen!
                ptb_1.Visible = ptb_2.Visible = ptb_3.Visible = ptb_4.Visible = ptb_5.Visible = ptb_6.Visible = ptb_7.Visible = ptb_host_1.Visible = ptb_host_2.Visible = ptb_host_3.Visible = ptb_host_4.Visible = ptb_host_5.Visible = ptb_host_6.Visible = ptb_host_7.Visible = ptb_stack_back.Visible = false; // Hide some cards :)
                ptb_status.Visible = true;
                ptb_status.Image = Image.FromFile("assets/hit.png");
                this.BackColor = lbl_inzet.BackColor = lbl_euro.BackColor = lbl_balance.BackColor = Color.DarkGreen;
                btn_Ok.Visible = btn_Ok.Enabled = true;
                if (HostTotal > UserTotal) {
                    lbl_state.Text = "De host heeft gehit, en gewonnen!";
                    lbl_state.Visible = true;
                    lbl_info.Text = "De host heeft gewonnen, je bent je geboden chips verloren!";
                    lbl_info.Visible = true;
                    UserBank -= UserBet;
                    lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
                } else {
                    lbl_state.Text = "De host heeft gehit, maar verloren!";
                    lbl_state.Visible = true;
                    if (UserTotal >= 21) {
                        lbl_info.Text = "Je had over de 21 in putenwaarde, je bod is maal 3!";
                        lbl_info.Visible = true;
                        UserBank += UserBet * 3;
                        lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
                    } else {
                        lbl_info.Text = "Je had meer dan de host, je bod is maal 2!";
                        UserBank += UserBet * 2;
                        lbl_info.Visible = true;
                        lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
                    }
                }
            } else { ptb_status.Image = null; }
        }

        private void Btn_hit_Click(object sender, EventArgs e) {
            // Hit screen!
            ptb_1.Visible = ptb_2.Visible = ptb_3.Visible = ptb_4.Visible = ptb_5.Visible = ptb_6.Visible = ptb_7.Visible = ptb_host_1.Visible = ptb_host_2.Visible = ptb_host_3.Visible = ptb_host_4.Visible = ptb_host_5.Visible = ptb_host_6.Visible = ptb_host_7.Visible = ptb_stack_back.Visible = false; // Hide some cards :)
            ptb_status.Visible = true;
            ptb_status.Image = Image.FromFile("assets/hit.png");
            this.BackColor = lbl_inzet.BackColor = lbl_euro.BackColor = lbl_balance.BackColor = Color.DarkGreen;
            btn_Ok.Visible = btn_Ok.Enabled = true;
            if (HostTotal > UserTotal) {
                lbl_state.Text = "Je hebt gehit, maar bent verloren!";
                lbl_state.Visible = true;
                lbl_info.Text = "De host heeft gewonnen, je bent je geboden chips verloren!";
                lbl_info.Visible = true;
                UserBank -= UserBet;
                lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
            } else {
                lbl_state.Text = "Je hebt gehit, en je bent gewonnen!";
                lbl_state.Visible = true;
                if (UserTotal >= 21) {
                    lbl_info.Text = "Je had over de 21 in putenwaarde, je bod is maal 3!";
                    lbl_info.Visible = true;
                    UserBank += UserBet * 3;
                    lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
                } else {
                    lbl_info.Text = "Je had meer dan de host, je bod is maal 2!";
                    lbl_info.Visible = true;
                    UserBank += UserBet * 2;
                    lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
                }
            }
        }

        private void Btn_start_Click(object sender, EventArgs e) {
            // Check if its allowed to start another game.
            if (Allowed) {
                btn_start.BackColor = Color.Lime; // Update button color just to be sure.
                txt_inzet.ReadOnly = false; // Allow the user to enter a value in the box, this should be enabled but your never know...
                btn_start.Cursor = Cursors.Hand; // Update cusor to be sure.
                txt_inzet.Cursor = Cursors.IBeam; // Update cusor to be sure.
                lbl_state.Visible = lbl_info.Visible = ptb_status.Visible = btn_Ok.Visible = btn_Ok.Enabled = false; // Disable the element.
                if (txt_inzet.Text == "") { // Check if the user entered a value.
                    lbl_error.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
                    lbl_error.Text = "Geef een inzet!";
                } else if (int.Parse(txt_inzet.Text) < 9) { // check if the user its value is greater than 9.
                    lbl_error.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Regular);
                    lbl_error.Text = "Minimum inzet is 10!";
                } else { // Start game.
                    lbl_balance.Text = "Chips waarde: €" + UserBank.ToString();
                    lbl_error.Text = "";
                    this.Size = new System.Drawing.Size(980, 765);
                    btn_start.BackColor = Color.DarkRed;
                    txt_inzet.ReadOnly = true;
                    btn_start.FlatAppearance.MouseOverBackColor = btn_start.FlatAppearance.MouseDownBackColor = btn_start.BackColor;
                    btn_start.Enabled = false;
                    txt_inzet.Cursor = Cursors.No;
                    UserBet = int.Parse(txt_inzet.Text);
                    this.CenterToScreen();
                    HostTotal = UserTotal = 0;
                    HostTotal += HostRN = RN.Next(1, 14);
                    ptb_host_1.Image = Image.FromFile("assets/" + HostRN + ".png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_1.Image = Image.FromFile("assets/" + UserRN + ".png");
                    HostTotal += RN.Next(1, 14);
                    ptb_host_6.Visible = true;
                    ptb_host_6.Image = Image.FromFile("assets/back_blue.png");
                    UserTotal += UserRN = RN.Next(1, 14);
                    ptb_2.Image = Image.FromFile("assets/" + UserRN + ".png");
                    count += 2;
                }
            }
        }
    }
}
