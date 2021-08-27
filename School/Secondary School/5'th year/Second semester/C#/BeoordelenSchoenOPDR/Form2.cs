// ©Arthurdw
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BeoordelenSchoenOPDR
{
    public partial class Form2 : Form
    {
        Image[] images;
        int[] ratings;
        public Form2(Image[] imageData, int[] ratingData)
        {
            InitializeComponent();
            images = imageData;
            ratings = ratingData;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //code voor weergeven afbeeldingen
            txtres.Text = maakSamenvatting();
            for (int i = 0; i < images.Length; i++)
            {
                PictureBox ptb = tblshoes.Controls[i] as PictureBox;
                ptb.BackgroundImage = images[i];
            }
            foreach (Control ctrl in tblshoes.Controls) (ctrl as PictureBox).BackColor = Color.BlueViolet;
        }

        private string maakSamenvatting()
        {
            string res = "";
            string aantal = toonAantalBeoordelingen();
            string hoogste = toonHoogsteBeoordeling();
            string scoreNooit = toonScoreNietGegeven();
            res = aantal + "\r\n\r\n" + hoogste + "\r\n\r\n" + scoreNooit;
            return res;
        }

        private string toonScoreNietGegeven()
        {
            ArrayList unused = new ArrayList();
            for (int i = 1; i <= 5; i++) if (!ratings.Contains(i)) unused.Add(i);
            return $"De volgende scores heb je niet gegeven: \r\n{string.Join("\t", (int[])unused.ToArray(typeof(int)))}";
        }

        private string toonHoogsteBeoordeling()
        {
            return $"Hoogste score die je hebt gegeven: {ratings.Max()}/5";
        }

        private string toonAantalBeoordelingen()
        {
            return $"Aantal gegeven beoordelingen: {ratings.Count(n => n > 0)}/15";
        }
    }
}

