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

namespace Frequentietabel
{
    public partial class Form1 : Form
    {
        int[] DBlijst = new int[] { 94, 107, 88, 97, 105, 95, 93, 101, 99, 90, 112, 92, 104, 104, 85, 101, 118, 89, 109, 111, 118, 82, 100, 96, 102, 106, 98, 116, 81, 98, 86, 107, 103, 118, 103, 85, 109, 97, 106, 113, 110, 117, 95, 80, 94, 102, 86, 104, 95, 91, 120, 97, 102, 101, 111, 96, 112, 100, 99, 107, 97, 90, 113, 98, 89, 108, 82, 88, 115, 86, 87, 106, 102, 96, 103, 97, 104, 102, 98, 103, 105, 119, 79, 108, 91, 114, 94, 91, 85, 96, 95, 92, 106, 101, 99, 87, 110, 93, 100, 96 };
        int[] counter = new int[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList dataSet = new ArrayList();
            string result = "", sorted = "";
            for (int i = 0; i < DBlijst.Length; i++)
            {
                dataSet.Add(DBlijst[i]);
                if (dataSet.Count == 10)
                {
                    result += $"{String.Join("\t| ", (int[])dataSet.ToArray(typeof(int)))}\r\n";
                    dataSet = new ArrayList();
                }
            }
            dataSet = new ArrayList();
            Array.Sort(DBlijst);
            for (int i = 0; i < DBlijst.Length; i++)
            {
                dataSet.Add(DBlijst[i]);
                if (dataSet.Count == 10)
                {
                    sorted += $"{String.Join("\t| ", (int[])dataSet.ToArray(typeof(int)))}\r\n";
                    dataSet = new ArrayList();
                }
            }

            foreach (int number in DBlijst)
            {
                if (78 <= number && number <= 82) counter[0]++;
                else if (83 <= number && number <= 87) counter[1]++;
                else if (88 <= number && number <= 92) counter[2]++;
                else if (93 <= number && number <= 97) counter[3]++;
                else if (98 <= number && number <= 102) counter[4]++;
                else if (103 <= number && number <= 107) counter[5]++;
                else if (108 <= number && number <= 112) counter[6]++;
                else if (113 <= number && number <= 117) counter[7]++;
                else if (118 <= number && number <= 122) counter[8]++;
            }
            txtResult.Text = "Tabel:\r\n";
            txtResult.Text += result;
            txtResult.Text += "\r\nGesorteerd:\r\n";
            txtResult.Text += sorted;
            txtResult.Text += $"\r\nAantal\t| Tussen\t| Aantal\t| Verhouding\r\n";
            txtResult.Text += $"1\t| 78-82\t| {counter[0]}\t| {counter[0]}%\r\n" +
                $"2\t| 83-87\t| {counter[1]}\t| {counter[1]}%\r\n" +
                $"3\t| 88-92\t| {counter[2]}\t| {counter[2]}%\r\n" +
                $"4\t| 93-97\t| {counter[3]}\t| {counter[3]}%\r\n" +
                $"5\t| 98-102\t| {counter[4]}\t| {counter[4]}%\r\n" +
                $"6\t| 103-107\t| {counter[5]}\t| {counter[5]}%\r\n" +
                $"7\t| 108-112\t| {counter[6]}\t| {counter[6]}%\r\n" +
                $"8\t| 113-117\t| {counter[7]}\t| {counter[7]}%\r\n" +
                $"9\t| 118-122\t| {counter[8]}\t| {counter[8]}%\r\n";
        }
    }
}
