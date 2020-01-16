// ©Arthurdw | GO-AO 2019

// Shows a pictureset.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BesteKeuze
{
    public partial class Form1 : Form
    {
        // Declare base vars:
        Random rn = new Random();
        int selectedL = 0;
        int selectedR = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // Get random picture set:
            selectedL = rn.Next(1, 20);
            selectedR = selectedL;
            if (selectedL % 2 == 0) selectedR -= 1;
            else selectedR++;

            // Display picture set:
            btnlinks.BackgroundImage = Image.FromFile("AfbeeldingenBesteKeuze/" + selectedL + ".jpg");
            btnRechts.BackgroundImage = Image.FromFile("AfbeeldingenBesteKeuze/" + selectedR + ".jpg");
        }

        private void Btnlinks_Click(object sender, EventArgs e)
        {
            // Switch vars:
            int switcher = selectedL;
            selectedL = selectedR;
            selectedR = switcher;

            // Display picture set:
            btnlinks.BackgroundImage = Image.FromFile("AfbeeldingenBesteKeuze/" + selectedL + ".jpg");
            btnRechts.BackgroundImage = Image.FromFile("AfbeeldingenBesteKeuze/" + selectedR + ".jpg");
        }
    }
}
