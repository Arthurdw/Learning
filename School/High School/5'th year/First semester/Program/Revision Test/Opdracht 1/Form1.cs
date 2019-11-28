// ©Arthurd (Arthur De Witte [arthur.dewitte@gmail.com])
// Created for GO-AO Informatics test.

// A simple rights program.
// Check wich password has wich rights.
using System;
using System.Windows.Forms;

namespace Opdracht_1 {
    public partial class access : Form {
        // Declare vars & passwords.
        string code, cr;
        string admin = "BRAVO";
        string mod1 = "OSCAR";
        string mod2 = "DELTA";
        bool valid;

        public access() {
            InitializeComponent();
        }

        private void BtnVerify_Click(object sender, EventArgs e) {
            // Assign code from textbox:
            code = txtCode.Text.ToUpper();

            // Check if an entry was given & if given check if its valid:
            if (code.Length != 5) {
                txtRights.Text = "GEEN TOEGANG";
            } else if (code.ToUpper() == admin) {
                txtRights.Text = "ADMINRECHTEN";
            } else if (code.ToUpper() == mod1 || code.ToUpper() == mod2) {
                txtRights.Text = "WIJZIGRECHTEN";
            } else {
                // `HOTEL` validation.
                valid = true;
                for (int i = 0; i <= 4; i++) {
                    cr = code.Substring(i, 1);
                    if (cr != "H") {
                        if (cr != "O") {
                            if (cr != "T") {
                                if (cr != "E") {
                                    if (cr != "L") {
                                        valid = false;
                                    }

                                }
                            }
                        }
                    }
                }
                if (valid) {
                    txtRights.Text = "LEESRECHTEN";
                } else {
                    txtRights.Text = "GEEN TOEGANG";
                }
            }

        }
    }
}
