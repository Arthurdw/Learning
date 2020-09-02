// ©Arthurdw | GO-AO
using System;
using System.Windows.Forms;

namespace GGD
{
    public partial class Form1 : Form
    {
        int FirstNumber, SecondNumber, Steps;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGretig_Click(object sender, EventArgs e) =>
            ProcessGGD(GreedyAlgorithm);

        private int GreedyAlgorithm()
        {
            int Delimiter = FirstNumber > SecondNumber ? SecondNumber : FirstNumber;
            for (int i = Delimiter; i > 0; i--)
            {
                Steps++;
                if (FirstNumber % i == SecondNumber % i)
                {
                    return i;
                }
            }
            return 1;
        }

        private void ButtonEfficient_Click(object sender, EventArgs e) =>
            ProcessGGD(EfficientAlgorithm);

        private int EfficientAlgorithm() =>
            CalculateRecuresive(FirstNumber, SecondNumber);

        private int CalculateRecuresive(int firstNumber, int secondNumber)
        {
            Steps++;
            if (secondNumber == 0) return firstNumber;
            return CalculateRecuresive(secondNumber, firstNumber % secondNumber);
        }

        private void ProcessGGD(Func<int> ExecuteAlgorithm)
        {
            if (IsValidInput())
            {
                UpdateInput();
                UpdateOutput();
                Output1.Text = $"De GGD is {ExecuteAlgorithm()} ({Steps})";
            }
        }

        private bool IsValidInput()
        {
            bool ValidInput = true;
            try
            {
                int FirstNumberCheck = int.Parse(Input1.Text),
                    SecondNumberCheck = int.Parse(Input2.Text);
                if (FirstNumberCheck == 0 || SecondNumberCheck == 0)
                {
                    ValidInput = false;
                }
            }
            catch (Exception)
            {
                Output1.Text = "Invalid Input!";
                ValidInput = false;
            }

            return ValidInput;
        }

        private void UpdateInput()
        {
            FirstNumber = int.Parse(Input1.Text);
            SecondNumber = int.Parse(Input2.Text);
        }

        private void UpdateOutput()
        {
            Output1.Clear();
            Steps = 0;
        }
    }
}
