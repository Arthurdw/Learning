using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balken
{
    public partial class FormDraw : Form
    {
        private Color _color;
        private readonly Color _penColor;
        private Pen _frontColor;
        private Brush _backColor;
        private readonly Graphics g;
        int _red = 10;
        int _blue = 40;
        readonly int _standXLength = 30;
        int _standYLength = 10;
        int startPosX = 10;
        readonly int startPosY = 10;
        int maxCount = 0;

        public FormDraw()
        {
            InitializeComponent();

            // Base Color:
            _color = Color.FromArgb(255, _red, 200, _blue);
            _penColor = Color.Blue;

            // Graphics assign.
            g = pnlPaint.CreateGraphics();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (maxCount > 15)
            {
                return;
            } 
            else
            {
                // Create a block `i` times.
                for (int i = 0; i < 16; ++i)
                {
                    // Check all the colors.
                    _backColor = new SolidBrush(_color);
                    _frontColor = new Pen(_penColor, 3);

                    // start positions.
                    int endPosX = startPosX;
                    int endPosY = startPosY + _standYLength;

                    // Draw square with outline.
                    g.FillRectangle(_backColor, startPosX, startPosY, _standXLength, _standYLength);
                    g.DrawLine(_frontColor, startPosX, startPosY, endPosX, endPosY);
                    g.DrawLine(_frontColor, startPosX - 1, endPosY, endPosX + _standXLength + 2, endPosY);
                    g.DrawLine(_frontColor, startPosX + _standXLength, startPosY, endPosX + _standXLength, endPosY);

                    // Update position, length & color.
                    startPosX += _standXLength + 10;
                    _standYLength += 22;
                    _red += 15;
                    _blue += 5;
                    _color = Color.FromArgb(255, _red, 200, _blue);
                    ++maxCount;
                }
            }
        }
    }
}
