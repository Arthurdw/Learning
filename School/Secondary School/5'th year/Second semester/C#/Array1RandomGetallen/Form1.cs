using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array1RandomGetallen
{
    public partial class Form1 : Form
    {
        int[] randomGetallen;
        Random rn = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVullen_Click(object sender, EventArgs e)
        {
            randomGetallen = new int[100];
            for (int i = 0; i < randomGetallen.Length; i++)
            {
                randomGetallen[i] = rn.Next(1, 100);
            }
        }

        private void BtnTonen_Click(object sender, EventArgs e)
        {
            foreach (var numb in randomGetallen)
            {
                Console.WriteLine(numb);
            }
        }
    }
}
