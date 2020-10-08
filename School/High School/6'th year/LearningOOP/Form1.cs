// ©Arthurdw | GO-AO
using System;
using System.Windows.Forms;

namespace LearningOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            lblKey.Text = new ClAccessKey(txtInput.Text).GetCode();
            txtInput.Clear();
        }
    }
}
