using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Plusbutton_Click(object sender, EventArgs e) {
            double input_1 = double.Parse(txtinput1.Text);
            double input_2 = double.Parse(txtinput2.Text);
            double output, output_last;
            output_last = Convert.ToDouble(txtoutput.Text);
            output = input_1 + input_2;
            txtoutput.Text = output.ToString();
            txtlastoutput.Text = output_last.ToString();
        }

        private void Txtminbutton_Click(object sender, EventArgs e) {
            double input_1 = double.Parse(txtinput1.Text);
            double input_2 = double.Parse(txtinput2.Text);
            double output, output_last;
            output_last = Convert.ToDouble(txtoutput.Text);
            output = input_1 - input_2;
            txtoutput.Text = output.ToString();
            txtlastoutput.Text = output_last.ToString();
        }

        private void Txtmultibutton_Click(object sender, EventArgs e) {
            double input_1 = double.Parse(txtinput1.Text);
            double input_2 = double.Parse(txtinput2.Text);
            double output, output_last;
            output_last = Convert.ToDouble(txtoutput.Text);
            output = input_1 * input_2;
            txtoutput.Text = output.ToString();
            txtlastoutput.Text = output_last.ToString();
        }

        private void Txtpartbutton_Click(object sender, EventArgs e) {
            double input_1 = double.Parse(txtinput1.Text);
            double input_2 = double.Parse(txtinput2.Text);
            double output, output_last;
            output_last = Convert.ToDouble(txtoutput.Text);
            output = input_1 / input_2;
            txtoutput.Text = output.ToString();
            txtlastoutput.Text = output_last.ToString();
        }

        private void TxtCalcModulo_Click(object sender, EventArgs e) {
            double input_1 = double.Parse(txtinput1.Text);
            double input_2 = double.Parse(txtinput2.Text);
            double moduloOutput;
            moduloOutput = input_1 % input_2;
            txtModuloOut.Text = moduloOutput.ToString();
        }
    }
}
