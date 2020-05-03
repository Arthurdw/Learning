using System;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        int[] punten = new[] { 10, 20, 25, 35, 50, 60, 75, 95, 110 };
        string[] prijzen = new[] { "muntje", "mes", "zegel", "sleutel", "geldbeurs", "elf", "zwaard", "knots", "prinses" };
        Random rn = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Spelnr\t| Punten\t| Hoofdprijs";
            for (int i = 0; i < 20; i++)
            {
                int _punten = rn.Next(0, 121);
                string prijs = "Geen prijs.";
                for (int j = 0; j < punten.Length; j++)
                {
                    if (_punten >= punten[(punten.Length - 1) - j])
                    {
                        prijs = prijzen[(prijzen.Length - 1) - j].ToString();
                        break;
                    }
                }
                textBox1.Text += Environment.NewLine + $"{i + 1}\t| {_punten}\t| {prijs}";
            }
        }
    }
}
