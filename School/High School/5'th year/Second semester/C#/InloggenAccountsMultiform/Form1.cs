using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InloggenAccountsMultiform
{
    public partial class Form1 : Form
    {
        string[,] accounts;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            accounts = new string[,] { {"natacha","admin"},{"test","test"},
                {"Kiany","K123"}, { "Khiyi", "Amjad2732" }, 
                { "Daul", "Andy6179" }, { "De Witte", "Arthur5379" },
                { "Van den Berghe", "Demian1516" }, { "Bordeaud'huy", "Boris7111" }, { "De Bock", "Casper8539" }, 
                { "Tirsan", "Dragos3228" }, { "De Baene", "Emar6178" },
                { "Sandyck", "Gabriëlla7561" },
                { "De weirdt", "Gilles4893" }, { "Callebaut", "Gunar7189" }, 
                { "Valentine", "Jari6188" }, { "Paeme", "Jarno7120" },
                { "Van Parys", "Jean-Baptiste4713" }, { "Lievens", "Loeka2329" },
                { "Dewil", "Lucas6102" }, { "Hofman", "Lunar7649" },
                { "Dietens", "Nathan3180" }, { "Martens", "Remco1936" }, 
                { "Van Eetvelde", "Ruben6193" }, { "Vlaemynck", "Tomma2168" }, 
                { "De Coster", "Ward1190" }, { "Van Belleghem", "Yentl4927" } };

            Console.WriteLine("lengte array: " + accounts.GetUpperBound(0));
            Console.WriteLine("aantal: " + accounts.GetUpperBound(1));
        }

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            bool access = vindAccount();
            if (access)
            {
                FrmTekening frm = new FrmTekening(txtusernaam.Text);
                frm.Show();
            }
            else
            {
                FrmNoAccess frm = new FrmNoAccess();
                frm.Show();
            }
            
        }

        private bool vindAccount()
        {
            bool access = false;
            for (int i = 0; i <= accounts.GetUpperBound(0); i++)//accounts
            {
                access = (txtusernaam.Text.Equals(accounts[i, 0])) && (txtpaswoord.Text.Equals(accounts[i, 1]));
                if (access) break;
            }
            return access;
        }
    }
}
