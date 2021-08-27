// Created for GO-AO
// ©Arthurdw - Arthur De Witte
// A short collor guesser program.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kleuren
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random rn = new Random();
        int tries, correct, totalColors = 0;

        enum Colors
        {
            RoyalBlue = 1,
            SpringGreen = 2,
            MediumVioletRed = 3,
            LightSalmon = 4,
            DodgerBlue = 5
        }

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            g = pnlDisplay.CreateGraphics();
            foreach (var color in Enum.GetNames(typeof(Colors)))
            {
                CBColors.Items.Add(color);
                totalColors++;
            }
        }

        private void CBColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int winningNumb = rn.Next(1, totalColors);
            string colorName = Enum.GetName(typeof(Colors), winningNumb);
            g.Clear(Color.FromName(colorName));
            bool check = winningNumb == CBColors.SelectedIndex;
            string prefix = winningNumb == CBColors.SelectedIndex ? "Juiste gok" : "Foute gok";
            if (check) correct++;
            tries++;
            txtLog.Text += $"{prefix} - Ik: Color [{CBColors.SelectedItem}] - Hij: Color [{colorName}]." + Environment.NewLine;
            txtStatus.Text = $"Juist: {correct}/{tries} pogingen";
        }
    }
}
