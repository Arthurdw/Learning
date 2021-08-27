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

namespace ArraLisy
{
    public partial class Form1 : Form
    {
        string[] producten;
        double[] prijzen;
        double totaalprijs;
        ArrayList selected = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            producten = new string[] { "kaas", "baguette", "wijn" };
            prijzen = new double[] { 5.01, 4.26, 48.64 };
            lbProducten.Items.AddRange(producten);
            lbProducten.SetSelected(0, true);
            totaalprijs = 0;

            foreach (string item in producten)
            {
                ArrayList current = new ArrayList();
                current.Add(item);
                current.Add(0);
                selected.Add(current);
            }
        }

        private void BtnToRight_Click(object sender, EventArgs e)
        {
            foreach (ArrayList item in selected)
            {
                if (item[0] == lbProducten.SelectedItem)
                {
                    ArrayList mArrayList = (ArrayList)selected[selected.IndexOf(item)];
                    mArrayList[1] = (int)mArrayList[1] + 1;
                    if ((int)mArrayList[1] == 1) lbgdn.Items.Add(lbProducten.SelectedItem);
                    else
                    {
                        if ((int)mArrayList[1] == 2) lbgdn.Items.Remove(lbProducten.SelectedItem);
                        else lbgdn.Items.Remove($"{lbProducten.SelectedItem} ({(int)mArrayList[1] - 1})");
                        lbgdn.Items.Add($"{lbProducten.SelectedItem} ({(int)mArrayList[1]})");
                    }
                    break;
                }
            }
            totaalprijs += prijzen[lbProducten.SelectedIndex];
            lblTotaal.Text = $"De totale waarde van de winkelkar is: {totaalprijs:c}";
        }

        private void BtnToLeft_Click(object sender, EventArgs e)
        {
            lbgdn.Items.Remove(lbgdn.SelectedItem);
        }
    }
}
