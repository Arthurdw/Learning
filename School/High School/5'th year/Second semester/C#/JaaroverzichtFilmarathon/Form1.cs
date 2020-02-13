using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaaroverzichtFilmarathon
{
    public partial class GrafisheArrays : Form
    {
        Brush br;
        Graphics g;
        Random rn = new Random();
        string[] maanden = new string[] { "januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "oktober", "november", "december" };
        Color[] kleuren = new Color[] { Color.Aqua, Color.CadetBlue, Color.Indigo, Color.CornflowerBlue, Color.LightCyan, Color.LimeGreen, Color.Lime, Color.DarkGreen, Color.Green, Color.LawnGreen, Color.Brown, Color.Crimson };
        Font drawFont = new Font("Arial", 16);
        public GrafisheArrays()
        {
            InitializeComponent();
            g = pnlDisplay.CreateGraphics();
        }

        private void BtnWeergeven_Click(object sender, EventArgs e)
        {
            pnlDisplay.Refresh();
            int x = 0;
            for (int i = 0; i < maanden.Length; i++)
            {
                br = new SolidBrush(kleuren[i]);
                int aantal = rn.Next(47, 450);
                g.FillRectangle(br, x, 500-aantal, 700/maanden.Length, aantal);
                g.DrawString(maanden[i] + Environment.NewLine + aantal.ToString(), drawFont, br, x, 450 - aantal);
                x += 750 / maanden.Length;
            }
        }
    }
}
