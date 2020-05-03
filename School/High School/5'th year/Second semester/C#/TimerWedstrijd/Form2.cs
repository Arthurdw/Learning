using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerWedstrijd
{
    public partial class Form2 : Form
    {
        public Form2(Array list)
        {
            InitializeComponent();
            SetDefaultData(list);
        }

        private void SetDefaultData(Array list)
        {
            Array first = (Array) list.GetValue(1);
            Array second = (Array) list.GetValue(2);
            Array third = (Array) list.GetValue(3);
            Array fourth = (Array) list.GetValue(4);
            Array fifth = (Array) list.GetValue(0);
            if (first != null) setData(label1, button1, first);
            if (second != null) setData(label2, button2, second);
            if (third != null) setData(label3, button3, third);
            if (fourth != null) setData(label4, button4, fourth);
            if (fifth != null) setData(label5, button5, fifth);
        }

        private void setData(Label label, Button button, Array data)
        {
            label.Text = data.GetValue(0).ToString() + Environment.NewLine + "Time took: " + data.GetValue(1).ToString();
            button.BackgroundImage = (Image)data.GetValue(2);
        }


        private void PremiumFeature(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Oh, you have discovered a ProRacer Pro feature!\nWant to buy ProRacer Pro?", "ProRacer Pro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (question == DialogResult.Yes) System.Diagnostics.Process.Start("https://downloadmoreram.com/");
            else return;
        }
    }
}
