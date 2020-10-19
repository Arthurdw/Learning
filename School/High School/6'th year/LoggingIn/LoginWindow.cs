// ©Arthurdw | GO-AO
using System;
using System.Windows.Forms;

namespace LoggingIn
{
    public partial class LoginWindow : Form
    {
        private const string FileName = "users.csv";
        private const string RootPath = @"C:\Users\arthu\Desktop\C#\LoggingIn\bin\Debug\";
        private const string Scrambler = "987-+|/\\CaPtI{0}MaSPr}}_-%4";

        private readonly FileHandler _filer;

        public LoginWindow()
        {
            InitializeComponent();
            _filer = new FileHandler(RootPath + FileName);

            /*void AddUser(string name, string pass, AccountPermission perm)
            {
                _filer.AddLine(name, pass, new HashHandler($"{name}:{pass}", Scrambler).GetHashSha512(),
                    DateTime.Now.ToString(),
                    ((int) perm).ToString());
            }

            _filer.AddLine("Username", "ww", "hashedPw", "TijdstipUpdate", "Permissie");
            AddUser("@root", "admin", AccountPermission.Admin);
            AddUser("Arthur@dw.be", "PythonIsVeryNiceButItsIsVerySlow:(", AccountPermission.Admin);
            AddUser("Loeka@liev.ens", "CodingIsCool", AccountPermission.Member);
            AddUser("Jari@val.tin", "MaNameJeff", AccountPermission.Member);
            AddUser("Casper@music.ga", "Alcohol", AccountPermission.Member);
            AddUser("Ruben@eet.veld", "Julliete", AccountPermission.Member);
            AddUser("Ward@tv.tv", "Twitch.TV", AccountPermission.Member);
            AddUser("JB@go.vroem", "VROEM", AccountPermission.Member);*/
        }

        private bool HasValidInput() =>
            !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPass.Text);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!HasValidInput())
            {
                MessageBox.Show("Please fill in your username and password!", "Oops...");
                return;
            }
            if (!txtName.Text.Contains("@"))
            {
                MessageBox.Show("Invalid mail!", "Oops...");
                return;
            }
            try
            {
                HashHandler hasher = new HashHandler($"{txtName.Text}:{txtPass.Text}", Scrambler);
                AccountHandler accountHandler = new AccountHandler(hasher, _filer);
                if (accountHandler.IsValidPass())
                {
                    Account user = accountHandler.GetAccount();
                    if (user.Permission is AccountPermission.Admin)
                    {
                        this.Hide();
                        AdminWindow aw = new AdminWindow(accountHandler);
                        aw.Closed += (s, args) => this.Close();
                        aw.Show();
                    }
                    else
                    {
                        this.Hide();
                        MemberWindow mw = new MemberWindow();
                        mw.Closed += (s, args) => this.Close();
                        mw.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You provided the wrong credentials!", "Oops...");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Oh, it seems like an unexpected error occurred!\r\n{exception.Message}", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}