using System;
using System.Drawing;
using System.Windows.Forms;

namespace HEXA_NR_KLEUR
{
    public partial class Form1 : Form
    {
        int red, green, blue;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text = "RBG(RED, GREEN, BLUE)" + Environment.NewLine;
            txtResult.ForeColor = Color.Black;
            string hexa = txtInput.Text;
            if (hexa.Length==6) {
                try
                {
                    red = int.Parse(hexa.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    green = int.Parse(hexa.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    blue = int.Parse(hexa.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid input!" + Environment.NewLine + "`" + txtInput.Text + "`" + Environment.NewLine + "Isn't a valid hex number!", "ERROR");
                    return;
                }
                if (blue < 180 || red < 180 || green < 180) txtResult.ForeColor = Color.White;
                txtResult.BackColor = Color.FromArgb(255, red, green, blue);
                txtResult.Text += "RGB(" + red + ", " + green + ", " + blue + ")";
            }
            else MessageBox.Show("A hex value should be like this:" + Environment.NewLine + "`1A2B3C`", "ERROR");
        }
    }
}
