using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
        ArrayList UserDataBase = new ArrayList();
        // DB model:
        // Every user will be stored as an `ArrayList` object.
        // In that object the user and its password will be stored like this:
        // [0] - Username
        // [1] - Password`
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUser()
        {
            // Check if the user entered all params.
            if (String.IsNullOrWhiteSpace(txtUser.Text) || String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please fill in all required parameters.", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string user = txtUser.Text, password = txtPass.Text;
            if (password.Length < 8) MessageBox.Show("The password has to be atleast 8 characters!", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!Char.IsLower(char.Parse(password.Substring(0, 1)))) MessageBox.Show("The password its first character has to be lowercase letter!", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!password.Any(char.IsDigit) || !password.Any(char.IsUpper)) MessageBox.Show("The password must atleast contain a number and a capital letter!", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bool allowed = true;
                int count = 0;
                foreach (string[] userObj in UserDataBase)
                {
                    string _subExpr = count == 0 ? String.Empty : $" ({count})";
                    string _subStr = count >= 1 ? user.Substring(0, user.Length - 4) + _subExpr : (user + _subExpr);
                    if (userObj[0] == _subStr) count++;
                    _subExpr = count == 0 ? String.Empty : $" ({count})";
                    if (count == 1) user += _subExpr;
                    else user = count != 0 ? user.Substring(0, user.Length - 4) + _subExpr : String.Empty;
                    if (userObj[1] == password)
                    {
                        MessageBox.Show("Someone already used this password, please create another one!", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        allowed = false;
                    }
                }
                if (allowed) UserDataBase.Add(new string[] { user, password});
            }
        }

        private void ShowPassWords()
        {
            string finalResult = "";
            foreach (string[] user in UserDataBase) finalResult += $"{user[0]}\t| {user[1]}" + Environment.NewLine;
            txtResult.Text = finalResult;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) AddUser();
            else if (e.KeyData == Keys.Escape) ShowPassWords();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) AddUser();
            else if (e.KeyData == Keys.Escape) ShowPassWords();
        }
    }
}
