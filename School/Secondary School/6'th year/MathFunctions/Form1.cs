// ©Arthurdw | GO-AO
using System;
using System.Windows.Forms;
using static System.Math;

namespace MathFunctions
{
    public partial class Form1 : Form
    {
        private double _xOffsetSelected, _xOffsetDivided, _xOffsetPower, _xOffsetSquareRoot;
        private Func<double, double> _xEventSelected, _xEventDivided, _xEventPower, _xEventSquareRoot;

        public Form1()
        {
            InitializeComponent();
            _xOffsetDivided = 1;
            _xOffsetPower = -9;
            _xOffsetSquareRoot = 0;

            _xEventDivided = (double x) => 1 / x;
            _xEventPower = (double x) => Pow(x, 2);
            _xEventSquareRoot = (double x) => Sqrt(x) + 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbSelector.Text))
            {
                switch (cbSelector.Text)
                {
                    case "y = 1/x":
                        _xOffsetSelected = _xOffsetDivided;
                        _xEventSelected = _xEventDivided;
                        break;
                    case "y = x²":
                        _xOffsetSelected = _xOffsetPower;
                        _xEventSelected = _xEventPower;
                        break;
                    case "y = (vierkants wortel van x) + 1":
                        _xOffsetSelected = _xOffsetSquareRoot;
                        _xEventSelected = _xEventSquareRoot;
                        break;
                    default:  // This should never get triggered!
                        return;
                }

                for (int i = 0; i < 19; i++)
                {
                    ((Label)tblOutput.Controls[(i + 1) * 2 - 2]).Text = (i + _xOffsetSelected).ToString();
                    ((Label) tblOutput.Controls[(i + 1) * 2 - 1]).Text = _xEventSelected(Double.Parse((i + _xOffsetSelected).ToString())).ToString();
                }
            }

        }
    }
}
