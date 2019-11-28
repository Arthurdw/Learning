using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkels
{
    public partial class Cirkels : Form
    {
        private Color _color;
        private Brush _backColor;
        private readonly Graphics g;
        Random rn;
        public Cirkels()
        {
            InitializeComponent();

            g = pnlShow.CreateGraphics();
        }

        private void Cirkels_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; ++i)
            {
                _color = Color.FromArgb(255, rn.Next(0, 256), rn.Next(0, 256), rn.Next(0, 256));
            }
        }
    }
}
