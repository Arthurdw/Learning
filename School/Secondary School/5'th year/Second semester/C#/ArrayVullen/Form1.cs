using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrayVullen
{
    public partial class Form1 : Form
    {
        int[] numbList = new int[10];
        int input, counter;
        public Form1()
        {
            InitializeComponent();
            counter = 0;
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                input = int.Parse(txtinput.Text);
                if (!(input >= 100 && input <= 999)) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Geef een geldig nummer als invoer.\r\nHet nummer moet tussen de 100-900 zijn!", "Foutmelding...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtinput.Clear();
            if (counter == numbList.Length - 1)
            {
                txtResult.Text = $"De som van alle getallen is {numbList.Sum()}\r\nHet gemiddelde van alle getallen is {numbList.Average()}\r\nDe getallen van klein naar groot\r\n";
                Array.Sort(numbList);
                foreach (var item in numbList) txtResult.Text += $"{item}\t";
                return;
            }
            if (counter >= numbList.Length)
            {
                if (MessageBox.Show($"Oh, er zitten al {numbList.Length} items in de lijst.\r\nWil je dat ik het herbegin en erin voeg?", "Restart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numbList = new int[10];
                    counter = 0;
                }
                else return;
            }
            txtResult.Clear();
            numbList[counter] = input;
            foreach (var item in numbList) txtResult.Text += $"{item}\t";
            counter++;
            txtinput.Focus();
        }
    }
}