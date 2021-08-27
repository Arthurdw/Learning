using System.Drawing;
using System.Windows.Forms;

namespace Kleuren
{
    public partial class Form1 : Form
    {
        private Graphics g;

        // private Color[] colors;
        private Image rocket;

        private Point location;

        public Form1()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void InitializeProgram()
        {
            Bitmap bm = new Bitmap(
                Image.FromFile("C:\\Users\\arthu\\Desktop\\Kleuren\\bin\\Debug\\assets\\unnamed.png"), 100, 100);
            bm.MakeTransparent();
            rocket = bm;
            g = panel1.CreateGraphics();
            // panel1.BackgroundImage = Image.FromFile("C:\\Users\\arthu\\Desktop\\Kleuren\\bin\\Debug\\assets\\unnamed.jpg");
            // colors = new Color[] { Color.Gray, Color.LightGray, Color.DarkGray};
            location = new Point(150, 200);
            panel1.Invalidate();
        }

        private void DrawPanel(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            g.DrawImage(rocket, location);
            // g.FillRectangle(new SolidBrush(colors[0]), 10, 20, 100, 100);
            // g.FillEllipse(new SolidBrush(colors[1]), 120, 20, 100, 100);
            // Point[] points = new Point[] { new Point(290, 20), new Point(360, 110), new Point(220, 110) };
            // g.FillPolygon(new SolidBrush(colors[2]), points);
        }

        private void MoveImage(int x, int y)
        {
            location = new Point(x, y);
            panel1.Invalidate();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                case Keys.Up:
                    MoveImage(location.X, location.Y - 3);
                    break;

                case Keys.Right:
                    MoveImage(location.X + 3, location.Y);
                    break;

                case Keys.Left:
                    MoveImage(location.X - 3, location.Y);
                    break;

                case Keys.Down:
                    MoveImage(location.X, location.Y + 3);
                    break;

                default:
                    break;
            }
        }
    }
}