using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Bots_Stats
{
    public partial class DBS : Form
    {
        // Declare base (empty) variables.
        int servers, commands;


        public DBS()
        {
            InitializeComponent();
        }

        private bool InitializeVariables()
        {
            try
            {
                servers = int.Parse(txtServers.Text);
                commands = int.Parse(txtCommands.Text);
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
         }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtData.Clear();
            if (InitializeVariables())
            {
                double greatness_calc = ((double)servers / (double)commands)/100;
                double greatness = (greatness_calc > 1) ? 1 : ((greatness_calc < 0) ? 0 : greatness_calc);
                var pre = servers++;
                var post = ++servers;
                txtData.Text = string.Format("Bot greatness: {0:P2}\r\n", greatness);
                txtData.Text += string.Format("Internal data:\r\nPre process: {0}, Post process: {1}", pre, post);
            }
            else txtData.Text = "Oops, wrong (maybe empty) input!";
        }
    }
}
