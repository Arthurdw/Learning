// ©Arthurdw | GO-AO 2019

// A project to draw a illusion with a color of choice.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROJECT_3_GETALCHECK // Niet naar de naam hiervan kijken, was een foutje :/
{
    public partial class Ilusion : Form
    {
        // Declaring base vars:
        Graphics g;
        Brush br;
        Random rn = new Random();

        // Block vars:
        int xStartPos = 0;
        int yStartPos = 0;
        int blockWidth = 40;
        int blockHeight = 40;
        int ySpacing = 2;

        // Full drawing vars:
        int maxBlocksX = 8;
        int maxBlocksY = 10;

        public Ilusion()
        {
            InitializeComponent();

            // Create our usable graphics panel:
            g = pnlShow.CreateGraphics();
        }

        private void CbSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Temp vars:
            int currentPosX = xStartPos;
            int currentPosY = yStartPos;
            int posXSelected = 0;
            int currentBlockWidth = blockWidth;
            int currentBlockHeight = blockHeight;
            br = new SolidBrush(Color.Black);

            // Assign background color:
            switch (cbSelected.Text)
            {
                case "(Kies een kleur.)":
                    g.Clear(Color.White);
                    break;
                case "Lime":
                    g.Clear(Color.Lime);
                    break;
                case "Tomato":
                    g.Clear(Color.Tomato);
                    break;
                case "Cornflowerblue":
                    g.Clear(Color.CornflowerBlue);
                    break;
                case "Aquamarine":
                    g.Clear(Color.Aquamarine);
                    break;
                case "Orange":
                    g.Clear(Color.Orange);
                    break;
                case "BlueViolet":
                    g.Clear(Color.BlueViolet);
                    break;
                default:
                    break;
            }

            // Draw illusion:
            for (int i = 0; i < maxBlocksY; i++)
            {
                bool first = true;
                currentPosX = rn.Next(0, blockWidth);
                for (int j  = 0;  j  < maxBlocksX;  j++)
                {
                    if (first)
                    {
                        currentBlockWidth = 600;
                        currentBlockHeight = ySpacing;
                        posXSelected = 0;
                    }
                    else
                    {
                        currentBlockWidth = blockWidth;
                        currentBlockHeight = blockHeight;
                        posXSelected = currentPosX;
                    }
                    g.FillRectangle(br, posXSelected, currentPosY, currentBlockWidth, currentBlockHeight);
                    if (first)
                    {
                        currentPosY += ySpacing;
                        first = !first;
                    }
                    else currentPosX += blockWidth * 2;
                }
                currentPosY += blockHeight;
            }
        }
    }
}
