using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform1
{
    public partial class Drawing : Form
    {
        public Drawing(string name)
        {
            InitializeComponent();
            lblName.Text = name;
        }
    }
}
