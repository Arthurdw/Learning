using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform1
{
    public partial class Login : Form
    {
        string[,] accounts; 
        public Login()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            accounts = new string[,] { { "Khiyi", "Amjad2732" }, { "Daul", "Andy6179" }, { "De Witte", "Arthur5379" }, { "Van den Berghe", "Demian1516" }, { "Bordeaud'huy", "Boris7111" }, { "De Bock", "Casper8539" }, { "Tirsan", "Dragos3228" }, { "De Baene", "Emar6178" }, { "Sandyck", "Gabriëlla7561" }, { "De weirdt", "Gilles4893" }, { "Callebaut", "Gunar7189" }, { "Valentine", "Jari6188" }, { "Paeme", "Jarno7120" }, { "Van Parys", "Jean-Baptiste4713" }, { "Lievens", "Loeka2329" }, { "Dewil", "Lucas6102" }, { "Hofman", "Lunar7649" }, { "Dietens", "Nathan3180" }, { "Martens", "Remco1936" }, { "Van Eetvelde", "Ruben6193" }, { "Vlaemynck", "Tomma2168" }, { "De Coster", "Ward1190" }, { "Van Belleghem", "Yentl4927" } };
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // accounts = [["Khiyi", "Amjad2732"], ["Daul", "Andy6179"], ...]
            // >>> acc = accounts[i]
            // >>> acc
            // <-- [ "Khiyi", "Amjad2732" ]
            // >>> type(acc)
            // <-- list
            // >>> acc[0]
            // <-- 'Khiyi'
            // >>> acc[1]
            // <-- 'Amjad2732'
            for (int i = 0; i < accounts.GetUpperBound(0); i++)
            {
                string[] user = new string[2];
                Array.Copy(accounts, i, user, 2);
                if (accounts[i] == new string[] { txtUsername.Text, txtPassword.Text})
                {

                }
            }
            Drawing frm = new Drawing();
            frm.Show();
        }
    }
}
