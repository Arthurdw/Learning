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

namespace RadioRockNRoll
{
    public partial class FrmAdmin : Form
    {
        private CLdatabeheer db { get; set; }
        private CLspelersbeheer sb { get; set; }
        private CLbestandsbeheer bb { get; set; }

        public FrmAdmin(CLdatabeheer db, CLspelersbeheer sb)
        {
            InitializeComponent();
            InitializeForm(db, sb);
        }

        private void InitializeForm(CLdatabeheer db, CLspelersbeheer sb)
        {
            this.db = db;
            this.sb = sb;
            this.bb = new CLbestandsbeheer(Directory.GetCurrentDirectory());
        }

        private void deelnemersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgDeelnemers.DataSource = sb.Spelers;
        }

        private void importerenUitBestand()
        {
            dgDeelnemers.DataSource = bb.GetData();
        }

        private void importeerNieuweDeelnemersToolStripMenuItem_Click(object sender, EventArgs e) =>
            importerenUitBestand();

        private void importeerPrijzenToolStripMenuItem_Click(object sender, EventArgs e) =>
            importerenUitBestand();
    }
}
