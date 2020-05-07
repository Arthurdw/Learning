using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedDecypher
{
    public partial class Form1 : Form
    {

        public Button[] buttonList;
        readonly List<Pattern> patterns;

        public Form1()
        {
            InitializeComponent();
            patterns = new List<Pattern>();
            buttonList = new Button[] { 
                button1, button2, button3, button4, button5, button6, button7, button8, button9,
                button10, button11, button12, button13, button14, button15, button16, button17,
                button18, button19, button20, button21, button22, button23, button24, button25 };
        }

        private void ToggleItem(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (btn == null) return;
            if (btn.BackColor == Color.Green) btn.BackColor = Color.White;
            else btn.BackColor = Color.Green;
        }

        private void ShowPattern(object sender, MouseEventArgs e)
        {
            if (ListBoxPatterns.SelectedItem != null)
            {
                foreach (Pattern ptrn in patterns)
                {
                    if (ptrn.description == ListBoxPatterns.SelectedItem.ToString())
                    {
                        for (int i = 0; i < buttonList.Length; i++)
                        {
                            buttonList[i].BackColor = ptrn.states[i] == 0 ? Color.White : Color.Green;
                            TextPatternDescription.Text = ptrn.description;
                            ButtonResetPattern.Text = "DELETE CHARACTER";
                        }
                    }
                }
            }
        }

        private void SavePattern(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextPatternDescription.Text))
            {
                MessageBox.Show("Please provide a name for this character.", "Oops...");
                return;
            }

            foreach (Pattern ptrn in patterns)
            {
                if (ptrn.description == TextPatternDescription.Text.Trim())
                {
                    MessageBox.Show("This character exists.", "Oops...");
                    return;
                }
            }

            int[] data = new int[25];
            for (int i = 0; i < data.Length; i++) data[i] = buttonList[i].BackColor == Color.Green ? 1 : 0;
            if (!data.Contains(1)) MessageBox.Show("Please provide a pattern for this character.", "Oops...");
            else
            {
                Pattern pat = new Pattern
                {
                    description = TextPatternDescription.Text.Trim(),
                    states = data
                };
                patterns.Add(pat);
                TextPatternDescription.Text = null;
                ResetPattern(sender, e);
                ListBoxPatterns.Items.Add(pat.description);
            }
        }

        private void ResetPattern(object sender, EventArgs e)
        {
            if (ButtonResetPattern.Text == "DELETE CHARACTER") {
                foreach (Pattern ptrn in patterns)
                {
                    if (ptrn.description == ListBoxPatterns.SelectedItem.ToString())
                    {
                        patterns.Remove(ptrn);
                        break;
                    }
                }
                ButtonResetPattern.Text = "RESET PATTERN";
                ListBoxPatterns.Items.Remove(ListBoxPatterns.SelectedItem);
            }
            foreach (Button btn in buttonList) btn.BackColor = Color.White;
        }

        private void SavePatternsAs(object sender, EventArgs e)
        {
            string path = null;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                }
            }
            if (path == null)
            {
                MessageBox.Show("Please select a valid folder to save the file.", "Oops...");
                return;
            }
            using (StreamWriter file = File.CreateText(path + "\\characters" + new Random().Next(0, 10000) + ".txt"))
            {
                string data = "";
                foreach (Pattern ptrn in patterns)
                {
                    data += $"\"{ptrn.description}\", {String.Join(", ", ptrn.states)}\n";
                }
                file.Write(data);
            }
        }

        private class Pattern
        {
            public string description;
            public int[] states = new int[25];
        }
    }
}
