// ©Arthurdw | Created in preparation for the c# exam. (GO-AO)

// Displays a line with a random color.
// The colors will switch from a random blue color to a random yellow color.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quest1
{
    public partial class Quest1 : Form
    {
        // Startup position:
        int xStartPos = 360; // Horizontal start position.
        int yStartPos = 0; // Vertical start position.

        // General settings:
        int xAmount = 10; // Amount of times it should display a block horizantally.
        int yAmount = 5; // Amount of times a row should be displayed.

        // Block settings:
        int yHeight = 37; // The height of a block.

        // Code starts here, if you don't know what you're doing don't edit this.
        Graphics g;
        Brush br;
        Random rn = new Random();

        public Quest1()
        {
            InitializeComponent();

            // Create a usable graphics panel.
            g = pnlShow.CreateGraphics();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Base declaration & assigment:
            int xPosCurrent = xStartPos;
            int yPosCurrent = yStartPos;
            int width = 360 / (xAmount+2);
            int increaseFactor = yHeight / xAmount;
            bool blue = false;

            // Vertical lines right to left:
            for (int i = 1; i <= yAmount; ++i)
            {
                int height = 0;

                // Horizantal lines:
                for (int j = 0; j <= xAmount; ++j)
                {
                    // Fix the color:
                    if (blue)
                    {
                        br = new SolidBrush(Color.FromArgb(rn.Next(200, 255), 0, 0, rn.Next(200, 255)));
                        blue =! blue;
                    }
                    else
                    {
                        br = new SolidBrush(Color.FromArgb(rn.Next(200, 255), rn.Next(200, 255), rn.Next(200, 255), 0));
                        blue = !blue;
                    }
                    g.FillRectangle(br, xPosCurrent, yPosCurrent, width, height);
                    height += increaseFactor;
                    xPosCurrent -= width + ((360 / (xAmount + 2))/xAmount)*2;
                }

                // Update line:
                yPosCurrent += yHeight + 2;

                height = 0;
                // Horizantal lines left to right:
                for (int j = 0; j <= xAmount; ++j)
                {
                    // Fix the color:
                    if (blue)
                    {
                        br = new SolidBrush(Color.FromArgb(rn.Next(50, 255), 0, 0, 255));
                        blue = !blue;
                    }
                    else
                    {
                        br = new SolidBrush(Color.FromArgb(rn.Next(50, 255), 255, 255, 0));
                        blue = !blue;
                    }
                    g.FillRectangle(br, xPosCurrent, yPosCurrent, width, height);
                    height += increaseFactor;
                    xPosCurrent += width + ((360 / (xAmount + 2)) / xAmount) * 2;
                }
                
                // Update line:
                yPosCurrent += yHeight + 2;
            }
        }
    }
}
