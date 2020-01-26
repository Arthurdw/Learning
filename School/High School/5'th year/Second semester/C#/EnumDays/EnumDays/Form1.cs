using System;
using System.Windows.Forms;

namespace EnumDays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum DaysOfWeek
        {
            maandag = 1,
            dinsdag = 2,
            woensdag = 3,
            donderdag = 4,
            vrijdag = 5,
            zaterdag = 6,
            zondag = 7
        }

        private void btnDayNumb_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            // Returns the day value (number).
            foreach (var day in Enum.GetValues(typeof(DaysOfWeek))) // Loop trough all listed days.
            {
                if (txtDay.Text.ToLower().Equals($"{day}")) // Check if the selected day is the input value.
                {
                    txtResult.Text = $"Dit is de {(int)day}de/ste dag van de week!"; // Show the value.
                    break; // Stop searching for the day.
                } else txtResult.Text = $"Kon de dag \"{txtDay.Text.ToLower()}\" niet vinden!"; // Couldn't find it. ¯\_(ツ)_/¯
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            // Returns the day. (string)
            foreach (var day in Enum.GetValues(typeof(DaysOfWeek))) // Loop trough all listed days.
            {
                if (txtDayNumb.Text.Equals(((int)day).ToString())) // Check if the day is the same as the selected day in the enum.
                {
                    txtResult.Text = $"De {txtDayNumb.Text}de/ste dag is {day}!"; // Show the day.
                    break; // Stop searching for the day.
                }
                else txtResult.Text = $"Kon geen dag vinden met de waarde \"{txtDayNumb.Text}\"!\r\nKies een getal tussen 1 & 7!"; // Couldn't find the day!
            }
        }

        private void btnDayAndNumb_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            // Returns the day and day number!
            int dayNumber = (int)dtpSelected.Value.DayOfWeek; // Get the day number.
            txtResult.Text = $"Dat was een {Enum.GetName(typeof(DaysOfWeek), dayNumber)}, dus de {dayNumber}de/ste dag van de week!"; // Display the day & day number!
        }
    }
}
