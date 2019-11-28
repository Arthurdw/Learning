// ©Arthurd (Arthur De Witte [arthur.dewitte@gmail.com])
// Created for GO-AO Informatics test.

// This program will "generate" a kind of code using a visual representation and a acces code.
// This program will display/let you know when somethings wrong.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opdracht_2 {
    public partial class progrm : Form {
        Brush br;
        Graphics g;
        Random rn = new Random();
        public progrm() {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
            // QUICK RESET:
            pnlCanvas.BackColor = Color.LightSlateGray;
            txtCode.Clear();
            br = new SolidBrush(Color.Green);
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            // QUICK RESET:
            pnlCanvas.BackColor = Color.LightSlateGray;
            int startPosX = 10;
            int startPosY = 10;
            int height = 40;
            int width = 40;
            int between = 10;
            g.Clear(Color.LightSlateGray);

            // Declare & read vars.
            int code = 0;
            try {
                code = int.Parse(txtCode.Text);
            } catch (Exception) {
                txtCode.Clear();
                MessageBox.Show("Je voerde geen getal in! Herbegin!", "Oeps...");
                return;
            }
            // Perform checks & draw squares!
            if (code%rn.Next(1,10) == 0) {
                pnlCanvas.BackColor = Color.DarkRed;
            } else {
                for (int i = 0; i < rn.Next(1, 10) % 5; i++) {
                    g.FillRectangle(br, startPosX, startPosY, width, height);
                    startPosX += width + between;
                }
            }
        }
    }
}
