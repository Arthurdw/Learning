using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoeken
{
    public partial class Form1 : Form
    {
        string[] names = new string[] { "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur", "Arthur" };
        public Form1()
        {
            InitializeComponent();
        }

        private void searchNameInArray(bool last = false)
        {
            int found = -1;
            if (CheckInput()) return;
            if (last) found = Array.LastIndexOf(names, txtSearch.Text);
            else found = Array.IndexOf(names, txtSearch.Text);
            if (found > -1) txtResult.Text = $"De naam \"{txtSearch.Text}\" werd gevonden op positie: {found}";
            else txtResult.Text = "Er werden geen namen gevonden.";
        }

        private bool CheckInput()
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Gelieve hier iets geldig in te voeren.";
                return true;
            }
            return false;
        }

        private void OpEersteIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchNameInArray();
        }

        private void OpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchNameInArray(true);
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckInput()) return;
            string result = Array.Find(names, search => search.Equals(txtSearch.Text));
            if (String.IsNullOrEmpty(result)) txtResult.Text = "Er werd geen naam gevonden.";
            else txtResult.Text = result;
        }

        private void ZoekManueelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckInput()) return;
            ArrayList results = new ArrayList();
            for (int i = 0; i < names.Length; i++)
            {
                results.Add($"{txtSearch.Text} gevonden op positie {i}.");
            }
            txtResult.Text = String.Join("\r\n", results);
        }
    }
}
