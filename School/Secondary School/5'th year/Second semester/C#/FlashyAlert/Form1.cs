using FlashyAlert.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlashyAlert
{
    public partial class Form1 : Form
    {
        private static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateForm("Eventjes geduld...\n\rUpdate in process.", Resources.info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateForm("Flushing data...\n\rUpdate in process.", Resources.delete);
        }

        public static void CloseForm(Form frm)
        {
            frm.Close();
            --count;
        }


        private static void CreateForm(string msg, Image ico)
        {
            count++;
            AlertDisplay frm = new AlertDisplay(msg, ico, count);
            frm.Show();
        }
    }
}
