using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace AfvalWater
{
    public partial class Form1 : Form
    {
        int totaal;
        Graphics g;
        Random rn = new Random();
        Color[] colorList;
        ArrayList container;
    public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            g = pnlShow.CreateGraphics();
            totaal = 0;
            container = new ArrayList();
            colorList = new[] { Color.Indigo, Color.AliceBlue, Color.Aqua,Color.MidnightBlue, Color.Aquamarine,Color.LavenderBlush, Color.Azure, Color.Blue, Color.CadetBlue, Color.Lavender, Color.Lime, Color.LimeGreen, Color.Salmon, Color.Snow, Color.CornflowerBlue, Color.DarkBlue, Color.DarkCyan, Color.LawnGreen, Color.DarkTurquoise, Color.SeaShell, Color.DeepSkyBlue,Color.GreenYellow, Color.SandyBrown, Color.SeaGreen, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle, Color.Tomato, Color.Turquoise, Color.Violet, Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen, Color.Coral,Color.IndianRed, Color.RosyBrown, Color.RoyalBlue, Color.SaddleBrown, Color.OrangeRed,Color.MistyRose, Color.Red};
            AddLading(0, "(lading)", "(waterstand)");
        }

        private void AddLading(int _lading, string _ladingText = null, string _totaalText = null)
        {
            container.Add(_lading);
            totaal += _lading;
            if (totaal > 50000)
            {
                totaal = _lading;
                pnlShow.Refresh();
                container = new ArrayList();
            }
            DrawTotal();
            lblLading.Text = _ladingText == null ? $"{_lading} LITER" : "(lading)";
            lblStand.Text = _totaalText == null ? $"{totaal} LITER" : "(waterstand)";
        }

        private void DrawTotal(object count = null)
        {
            int y = 0;
            if (count == null)
            {
                for (int i = 0; i < container.Count; i++)
                {
                    y += (int)container[i];
                    g.FillRectangle(new SolidBrush(colorList[i]), 0, y, 250, (int)container[i]);
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            int addedValue = rn.Next(1000, 10001);
            AddLading(addedValue);
        }

        private void Btntest_Click(object sender, EventArgs e)
        {
            totaal = 0;
            AddLading(0, "(lading)", "(waterstand)");
        }
    }
}
