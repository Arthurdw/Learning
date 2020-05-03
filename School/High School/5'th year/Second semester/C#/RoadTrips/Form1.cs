using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadTrips
{
    public partial class Form1 : Form
    {
        string[] steden = new string[] { "Lille", "Arras", "Compeigne", "Parijs", "Orléands", "Vichy", "Lyon", "Avignon", "Marseille"};
        int[] km = new int[] { 60, 106, 203, 280, 406, 660, 750, 975, 1080 };
        public Form1()
        {
            InitializeComponent();
            foreach (string stad in steden) cbBestemming.Items.Add(stad);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string stad = "";
            double verbruik = 0, benzinetank = 0, benzineprijs = 0, budget = 0;
            try
            {
                verbruik = double.Parse(txtVerbruik.Text);
                benzinetank = double.Parse(txtTankGroote.Text);
                benzineprijs = double.Parse(txtBenzinePrijs.Text);
                budget = double.Parse(txtBudget.Text);
                stad = cbBestemming.Text.Trim();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul alle waarden in.", "Oi...");
                return;
            }
            string[] gepasseerd = new string[Array.IndexOf(steden, stad)];
            Array.Copy(steden, 0, gepasseerd, 0, Array.IndexOf(steden, stad));
            txtResultaat.Text = $"De trip naar {stad} is {km[Array.IndexOf(steden, stad)]}km.\r\n" +
                $"Je moet {Math.Floor(verbruik / 100 * km[Array.IndexOf(steden, stad)] / benzinetank)} keer tanken.\r\n" +
                $"Het zal {Math.Floor(verbruik / 100 * km[Array.IndexOf(steden, stad)] / benzinetank) * benzinetank * benzineprijs} euro kosten.\r\n" +
                $"Je zal de volgende steden passeerden:\r\n{String.Join(", ", gepasseerd)}";
            ptbIMG.Image = Image.FromFile($"assets/{stad}.jpg");
        }
    }
}
