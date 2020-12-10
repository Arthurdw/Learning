// Arthur De Witte | 6 Informaticabeheer | GO-Atheneum Oudenaarde

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioRockNRoll
{
    public partial class FrmInloggen : Form
    {
        private CLdatabeheer db;

        private string gebruikersnaam;
        private string passwoord;

        private bool inlogOK;

        public FrmInloggen()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void InitializeProgram()
        {
            db = new CLdatabeheer("06InfoArthur", "theWhiteA@6@21", "06InfoArthur", "arthur.go-ao.be", "3306");
            if (!db.ConnectionStatus)
            {
                DialogResult rs = MessageBox.Show("Kon geen verbinding maken met de database!", "Oops...", MessageBoxButtons.RetryCancel);
                switch (rs)
                {
                    case DialogResult.Retry:
                        InitializeProgram();
                        break;
                    default:
                        this.Close();
                        break;
                }
            }
        }

        private void btnNaarHetSpel_Click(object sender, EventArgs e)
        {
            this.gebruikersnaam = txtUsernaam.Text.Trim();
            this.passwoord = txtPaswoord.Text.Trim();

            if (this.gebruikersnaam.Length < 5 || this.passwoord.Length < 5)
            {
                ShowCredentialsNotFound();
                return;
            }

            CLloginbeheer lb = new CLloginbeheer(this.db, this.gebruikersnaam, this.passwoord);

            this.inlogOK = lb.IsValidLogin();

            if (inlogOK) new FrmSpelformulier(db, lb.users.First()).Show();
            else ShowCredentialsNotFound();
        }

        private DialogResult ShowCredentialsNotFound() => MessageBox.Show("Inloggegevens niet gevonden");
    }
}
