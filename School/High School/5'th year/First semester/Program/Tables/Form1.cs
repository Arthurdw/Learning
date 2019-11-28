using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            // Reading and declaring vars
            int number = 0;
            string response = string.Empty;
            bool displayVars = false;

            // Clearing the field.
            txtResponse.Clear();

            try
            {
                number = int.Parse(txtNumb.Text);
                response = string.Empty;
                displayVars = true;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Couldn't get the number!");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("The number is too big!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + ex.GetType());
            }

            if (displayVars)
            {
                // Display vars:
                for (int i = 1; i <= 10; i++)
                {
                    // 7 x 2 = 14
                    // 7 x 3 = 21
                    response += number + " x " + i + " = " + (i * number) + Environment.NewLine;
                    txtResponse.Text = response;
                }
            }
        }
    }
}
