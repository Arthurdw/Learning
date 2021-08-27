using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bookings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void InitializeProgram()
        {
            string connString =
                "Server=arthur.go-ao.be;Port=3306;SslMode=None;Database=06InfoArthur;Uid=arthur;Pwd=pass;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand("getAllBookings", conn) { CommandType = CommandType.StoredProcedure };

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                try
                {
                    adapter.Fill(dataSet, "data");
                    dgv.DataSource = dataSet.Tables["data"];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    MessageBox.Show(@"Er is een fout opgelopen bij het ophalen van de data.");
                }
            }

            lblBookingCount.Text = $@"{dgv.RowCount - 1} bookings";
            cbFilter.Items.Add("(geen filter)");

            for (int i = 0; i < dgv.RowCount - 2; i++)
            {
                string country = (string)dgv.Rows[i + 1].Cells[5].Value;

                if (!cbFilter.Items.Contains(country)) cbFilter.Items.Add(country);
            }
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            if (cbFilter.SelectedIndex != 0) SetFilter($"Country = '{cbFilter.Items[cbFilter.SelectedIndex]}'");
            else ((DataTable) dgv.DataSource).DefaultView.RowFilter = "";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            string f = $"LIKE '*{txtFilter.Text}*'";
            SetFilter($"FamilyName {f} OR Surname {f} OR Hotelname {f}");
        }

        private void SetFilter(string filter)
        {
            try
            {
                ((DataTable)dgv.DataSource).DefaultView.RowFilter = filter;
                lblBookingCount.Text = $@"{dgv.RowCount - 1} bookings";
            }
            catch (Exception _) { }
        }
    }
}