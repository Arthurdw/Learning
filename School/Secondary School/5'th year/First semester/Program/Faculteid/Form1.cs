using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculteid
{
    public partial class Form1 : Form
    {
        int amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ulong res = 1;
            try
            {
                amount = int.Parse(txtAmount.Text);
                for (int i = 1; i <= amount; i++)
                {
                    try
                    {
                        res = res * (ulong)i;
                        txtResult.Text += i + ": " + res + Environment.NewLine;
                    }
                    catch (System.OverflowException)
                    {
                        break;
                    }
                    
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Onbekend nummer!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.GetType());
            }
        }
    }
}
