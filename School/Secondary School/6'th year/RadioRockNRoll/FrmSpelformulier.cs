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
    public partial class FrmSpelformulier : Form
    {
        private CLdatabeheer db;
        private CLprijsbeheer pb;
        private CLspelersbeheer sb;

        private Speler SelectedSpeler { get; set; }
        private int Totaal { get; set; }

        public FrmSpelformulier(CLdatabeheer db, DataStructure gebruiker)
        {
            InitializeComponent();
            InitializeForm(db, gebruiker);
        }

        private void InitializeForm(CLdatabeheer db, DataStructure gebruiker)
        {
            this.Width = 700;
            lblDagBericht.Text = $@"Dag {gebruiker.voornaam}";
            btnSettings.Visible = gebruiker.gebruikersrecht is Rechten.Administrator;

            this.db = db;
            this.pb = new CLprijsbeheer(db);
            this.sb = new CLspelersbeheer(db);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pb.GenereerPrijzen();

            int waarde = 0;
            foreach (Prijs prijs in pb.prijzen.Values) waarde += prijs.Waarde;
            Totaal = waarde;
        }

        private void btnSpelen_Click(object sender, EventArgs e)
        {
            Speler splr = sb.KrijgRandomSpeler();
            lblLuisteraar.Text = $@"We spelen met {splr.Naam} {splr.Voornaam}{Environment.NewLine}" +
                                 $@"BEL: {splr.Gsm}";

            SelectedSpeler = splr;
        }

        private void VerwerkGok(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            if (pb.prijzen.Count == 0 || SelectedSpeler == null)
            {
                MessageBox.Show("Je moet eerst een zak samenstellen en een deelnemer bellen.");
                return;
            }

            try
            {
                int gegokteWaarde = int.Parse(txtGok.Text.Trim());

                if (gegokteWaarde < 100)
                {
                    MessageBox.Show("Voer een waarde zonder decimalen in dat groter is dan 100");
                    return;
                }

                if (Totaal * 0.9 <= gegokteWaarde && gegokteWaarde <= Totaal * 1.1)
                {
                    txtResponse.Text = "JE HEBT GEWONNEN!!!";
                    ptbZak.Image = Image.FromFile("./happy.png");
                    this.Width = 1410;

                    foreach (Prijs prijs in pb.prijzen.Values.OrderByDescending(p => p.Waarde).ToArray())
                    {
                        string prijsSegment = $"Prijs: {prijs.Naam.Trim()}";
                        string waardeSegment = $"Waarde: €{prijs.Waarde},00{Environment.NewLine}{Environment.NewLine}";
                        txtPrijzen.Text += prijsSegment.PadRight(50, ' ') + waardeSegment;
                    }

                    string sql = "DELETE FROM deelnemers " +
                                 $"WHERE gsm = {SelectedSpeler.Gsm} " +
                                 $"AND Naam = {SelectedSpeler.Naam} " +
                                 $"AND Voornaam = {SelectedSpeler.Voornaam};";

                    db.Execute(sql);
                    Console.WriteLine($"Er zijn {db.StatementRowsChanged} records verwijderd.");

                    int changedRecords = 0;

                    foreach (Prijs prijs in pb.prijzen.Values)
                    {
                        string priceSql = "UPDATE prijzen " +
                                          $"SET ActueleVoorraad = {prijs.Voorraad - 1} " +
                                          $"WHERE IDPrijs = {prijs.Id};";
                        db.Execute(priceSql);
                        changedRecords += db.StatementRowsChanged;
                    }

                    Console.WriteLine($@"Er zijn {changedRecords} records gewijzigd.");

                    // Nieuwe vooraaden:
                    pb = new CLprijsbeheer(db);

                    string addWinnerSql = "INSERT INTO gewonnen " +
                                          $"('{DateTime.UtcNow}', '{SelectedSpeler.Naam} " +
                                          $"{SelectedSpeler.Voornaam} - gsm: {SelectedSpeler.Gsm} " +
                                          $"heeft een zak ter waarde van " +
                                          $"€ {Totaal},00 gewonnen');";

                    db.Execute(addWinnerSql);
                    Console.WriteLine($"Er is/zijn {db.StatementRowsChanged} records toegevoegd in 'gewonnen'");
                }
                else
                {
                    txtResponse.Text = "Helaas, meer geluk de volgende keer!";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ongeldige gok waarde, dit moet een getal zijn.");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e) => new FrmAdmin(db, sb).Show();
    }
}
