// ©Arthurdw
using System;
using System.Collections;
using System.Windows.Forms;

//Proef 5info 2020
//"Boris", "Gunar", " Andy", "Emar", "Casper", "Ward", "Gilles", "Lucas", "Arthur", "Nathan", "Hofman Lunar", "Amjad", "Loeka", "Remco", "Jarno", "Gabriëlla", "Dragos", " Jari", " Yentl", "Demian", "Ruben", "Jean-Baptiste", "Tomma"

namespace OmBeurtAntwoorden
{
    public partial class Form1 : Form
    {
        Random rn = new Random();
        int count = 0;
        ArrayList itemsUsable = new ArrayList();
        string[] items = { "Boris", "Gunar", " Andy", "Emar", "Casper", "Ward", "Gilles", "Lucas", "Arthur", "Nathan", "Hofman Lunar", "Amjad", "Loeka", "Remco", "Jarno", "Gabriëlla", "Dragos", " Jari", " Yentl", "Demian", "Ruben", "Jean-Baptiste", "Tomma" };
        public Form1()
        {
            InitializeComponent();
            foreach (String item in items) itemsUsable.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            int sel = rn.Next(0, items.Length - 1);
            lblNaam.Text = items[sel];
            if (count >= 20)
            {
                itemsUsable.Remove(items[sel]);
                timer1.Stop();
                Console.WriteLine(string.Join(", ", (string[]) itemsUsable.ToArray(typeof(string))));
            }
        }
    }
}
