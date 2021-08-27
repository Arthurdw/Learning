// ©Arthurdw | GO-AO
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoggingIn
{
    public partial class AdminWindow : Form
    {
        private readonly AccountHandler _ah;

        public AdminWindow(AccountHandler accountHandler)
        {
            InitializeComponent();
            SetPassResetState(false);
            _ah = accountHandler;
            RefreshDataGrid();
        }

        private void SetPassResetState(bool state) =>
            txtPassReset.Visible = lblPassReset.Visible = state;

        private void RefreshDataGrid() =>
            dgData.DataSource = _ah.Accounts;

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPassResetState(true);
            txtPassReset.Select();
        }

        private void showAccountsToolStripMenuItem_Click(object sender, EventArgs e) =>
            RefreshDataGrid();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) =>
            this.Close();

        private void ResetPasswords(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtPassReset.Text) || txtPassReset.Text.Length < 7)
                {
                    MessageBox.Show("Invalid replacement password!", "Oops...");
                    return;
                }
                SetPassResetState(false);
                List<string[]> data = new List<string[]>();
                int counter = 0;
                data.Add(new string[] { "Username", "ww", "hashedPw", "TijdstipUpdate", "Permissie" });
                foreach (Account account in _ah.Accounts)
                {
                    Account newAccount = account;
                    if (!(account.Permission is AccountPermission.Admin))
                    {
                        newAccount = new Account(account.UserName,
                            txtPassReset.Text,
                            new HashHandler(txtPassReset.Text, _ah.Hasher.Scrambler).GetHashSha512(),
                            DateTime.Now,
                            account.Permission);
                        counter++;
                    }

                    data.Add(new[] { newAccount.UserName, newAccount.Password, newAccount.PasswordHashed, newAccount.LastUpdate.ToString(), ((int)newAccount.Permission).ToString() });
                }
                _ah.File.SetFile(data);
                _ah.ReloadAccountData();
                MessageBox.Show($"Het passwoord werd voor {counter} gebruikers gereset", "SUCCESS");
                RefreshDataGrid();
                txtPassReset.Clear();
            }
        }
    }
}