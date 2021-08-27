// Project created for GO-AO
// ©Arthurdw - Arthur De Witte

// Inchecken met nablijven achter 3x te laat.
using System;
using System.Windows.Forms;

namespace Nablijven
{
    public partial class Form1 : Form
    {
        int counter, dagenTeLaat, uur, minuut;

        TimeSpan tijd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Inchecken knopje:
            try
            {
                uur = int.Parse(txtUur.Text);
                minuut = int.Parse(txtMinuut.Text);
                if (uur > 24) throw new System.FormatException();
                if (minuut > 60) throw new System.FormatException();
            }
            catch (System.FormatException)
            {
                lblOut.Text = "Foute invoer.";
                return;
            }
            counter++;
            tijd = new TimeSpan(uur, minuut, 0);
            dagenTeLaat = tijd > new TimeSpan(8, 30, 0) ? ++dagenTeLaat : 0;
            string extra = dagenTeLaat > 2 ? "Je moet nablijven" : "Je bent nog safe";
            lblOut.Text = $"Dag {counter} - {tijd}. {dagenTeLaat} dagen op een rij te laat. {extra}.";
            ClearFields();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Reset knopje:
            counter = dagenTeLaat = 0;
            lblOut.Text = "";
            ClearFields();
        }

        private void ClearFields()
        {
            txtMinuut.Clear();
            txtUur.Clear();
        }
    }
}
