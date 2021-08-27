// ©Arthurdw
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeoordelenSchoenOPDR
{
    public partial class Form1 : Form
    {
        bool active = false;
        int current = 0;
        int[] ratings = new int[15];
        Image[] usedImages = new Image[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void beoordelingStartenToolStripMenuItem_Click(object sender, EventArgs e) => UpdateVision(true);

        private void stoppenToolStripMenuItem_Click(object sender, EventArgs e) => UpdateVision(false);

        private void SendVote(object sender, EventArgs e)
        {
            if (!active || sender == null) return;
            ratings[current] = int.Parse((sender as Button).Text);
            usedImages[current] = Image.FromFile($"shoes/{++current}.jpg");
            if (current >= 15) ShowNewForm();
            else pbschoen.BackgroundImage = Image.FromFile($"shoes/{current + 1}.jpg");
        }

        private void ShowNewForm()
        {
            Hide();
            Form2 frm = new Form2(usedImages, ratings);
            frm.Closed += (s, args) => Close();
            frm.Show();
        }

        private void UpdateVision(bool v)
        {
            active = v;
            pbschoen.BackgroundImage = v ? Image.FromFile("shoes/1.jpg") : null;
            if (!active) ShowNewForm();
        }
    }
}
