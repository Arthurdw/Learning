using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using useraccounts;

namespace UserAccounts
{
    public partial class Form1 : Form
    {
        private List<string[]> userData;

        public Form1()
        {
            InitializeComponent();
            userData = new List<string[]> {new[] {"Naam", "Passwoord Unhashed", "Passwoord Hashed"}};
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ProcessValidInput(txtName, txtPass))
            {
                userData.Add(new []{ txtName.Text, txtPass.Text, new CreateHash(txtPass.Text, "$-${0}#123456789!").getHashSHA512() });
                btnClear_Click(sender, e);
            }
        }

        private static bool IsValidString(string input) => !string.IsNullOrWhiteSpace(input);
        private static bool IsValidInput(TextBox txtName, TextBox txtPass) => IsValidString(txtName.Text) && IsValidString(txtPass.Text);

        private static bool ProcessValidInput(TextBox txtName, TextBox txtPass)
        {
            if (IsValidInput(txtName, txtPass)) return true;
            MessageBox.Show("Oops...", "Vul alsjeblieft beide gegevens in!");
            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void btnToCSV_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            DialogResult result = fbDialog.ShowDialog();

            string filePath = fbDialog.SelectedPath + "/accounts.csv";

            if (!string.IsNullOrWhiteSpace(fbDialog.SelectedPath))
            {
                File.Create(filePath).Close();
                StringBuilder sb = new StringBuilder();
                foreach (var user in userData) sb.AppendLine(string.Join(";", user));
                File.AppendAllText(filePath, sb.ToString());
                Console.WriteLine("");
            }
        }
    }
}
