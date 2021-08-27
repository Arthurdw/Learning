using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Datagridview
{
    public partial class Form1 : Form
    {
        private MySqlHandler _mySqlHandler;

        public Form1()
        {
            InitializeComponent();
            InitializeProgram();
        }

        private void InitializeProgram()
        {
            MySqlClient client = MySqlClient.From("username", "password", "database", "server");
            this._mySqlHandler = new MySqlHandler(client);

            InitializeDatagrid();
        }

        private void InitializeDatagrid()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter();
            mda.SelectCommand = this._mySqlHandler.Prepare(MySQLStatements.FetchAllData);
            DataTable dt = new DataTable();

            mda.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgvData.DataSource = bs;
            dgvData.Columns["IDlid"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ((BindingSource) dgvData.DataSource).DataSource as DataTable;

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            List<string> filters = new List<string>();

            foreach (DataGridViewColumn dgvc in dgvData.Columns)
            {
                int number;
                if (ReferenceEquals(typeof(string), dgvc.ValueType))
                    filters.Add($"[{dgvc.HeaderText}] = '{txtSearch.Text}'");
                else if (ReferenceEquals(typeof(int), dgvc.ValueType))
                {
                    if (int.TryParse(txtSearch.Text, out number))
                        filters.Add($"[{dgvc.HeaderText}] = {number}");
                }
            }

            dt.DefaultView.RowFilter = string.Join(" OR ", filters);
        }

        private void btnNewClient_Click(object sender, EventArgs e) => 
            new ClientEditor(this._mySqlHandler, this.InitializeDatagrid).Show();

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Gelieve een rij te selecteren!");
                return;
            }

            DataGridViewCellCollection dgvcc = dgvData.SelectedRows[0].Cells;
            if (ReferenceEquals(dgvcc[7].Value, null)) return;

            new ClientEditor(this._mySqlHandler,
                this.InitializeDatagrid,
                dgvcc[1].Value.ToString(),
                dgvcc[0].Value.ToString(),
                dgvcc[2].Value.ToString(),
                (int) dgvcc[3].Value,
                dgvcc[4].Value.ToString(),
                dgvcc[5].Value.ToString(),
                dgvcc[6].Value.ToString(),
                (int) dgvcc[7].Value).Show();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Gelieve een rij te selecteren!");
                return;
            }

            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                DataGridViewCellCollection dgvcc = row.Cells;
                if (ReferenceEquals(dgvcc[7].Value, null)) return;

                MySqlCommand cmd = this._mySqlHandler.Prepare(MySQLStatements.DeleteUser, ("@id", (int)dgvcc[7].Value));
                this._mySqlHandler.Execute(cmd);
            }
            this.InitializeDatagrid();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
            => this.InitializeDatagrid();
    }
}