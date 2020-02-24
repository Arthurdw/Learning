// ©Arthurdw | Arthur De Witte

// Created for GO-AO.
// This project is under an MIT License.

using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nummerplaten
{
    public partial class Nummerplaten : Form
    {
        // A list of invalid triple char strings.
        // If the triple chars are one of these words it will skip.
        readonly string[] invalid = new string[] { "GOD", "PIS", "KAK" };

        // This will save the current selected license plate.
        // ArrayList structure:
        // [0] Current number - `*1* AAA 000` | Integer
        // [1] Triple char counter: - `1 *AAA* 000` | Object
        //     [0] Triple char first char.  - `1 *A*AA 000` | Character
        //     [1] Triple char second char. - `1 A*A*A 000` | Character
        //     [2] Triple char third char.  - `1 AA*A* 000` | Character
        // [2] Final number counter - `1 AAA *000*` | Integer
        ArrayList currentPlate = new ArrayList();

        public Nummerplaten()
        {
            InitializeComponent();
            CheckForHumanErrors();
        }

        private void CheckForHumanErrors()
        {
            // Check if we have any combinations over for our plates.
            if (invalid.Length >= 17576) throw new SyntaxErrorException("You gave to many invalid plates. I have no combinations over.");
            // Check if every filter in the list is 3 chars long.
            foreach (string plate in invalid)
            {
                if (plate.Length != 3) throw new SyntaxErrorException("Invalid plates can only be specified with 3 chars.");
            }
        }

        private void AddLicensePlate()
        {
            // Check if we already have our default values.
            if (currentPlate.Count == 3) // We do.
            {
                string[] tripleChar = (string[])currentPlate[1];
                // Go to next index number.
                if ((tripleChar[0] + tripleChar[1] + tripleChar[2]).ToString() == "ZZZ") currentPlate[0] = (int)currentPlate[0] + 1;
                // Check if our plate is allowed.
                if (invalid.Contains((tripleChar[0] + tripleChar[1] + tripleChar[2]).ToString())) GenerateNextPlate(tripleChar);
                currentPlate[2] = (int)currentPlate[2] + 1;
                if ((int)currentPlate[2] == 1000)
                {
                    currentPlate[2] = 0;
                    GenerateNextPlate(tripleChar);
                }
            }
            else // We don't
            {
                currentPlate.Add(1);
                currentPlate.Add(new string[] { "A", "A", "A" });
                currentPlate.Add(0);
            }
            // Display the plate.
            // Fetch the current char list.
            string[] currChar = (string[])currentPlate[1];
            string plate = $"{currentPlate[0]} {currChar[0] + currChar[1] + currChar[2]} {currentPlate[2]:D3}";
            txtCurrent.Text = plate;
            txtResult.Text += $"{plate}, ";
        }

        private void GenerateNextPlate(string[] tripleChar)
        {
            for (int i = 0; i < tripleChar.Length; i++)
            {
                if (tripleChar[tripleChar.Length - 1 - i] == "Z") tripleChar[tripleChar.Length - 1 - i] = "A";
                else
                {
                    tripleChar[tripleChar.Length - 1 - i] = ((char)((int)(char.Parse(tripleChar[tripleChar.Length - 1 - i])) + 1)).ToString();
                    break;
                }
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            AddLicensePlate();
        }
    }
}
