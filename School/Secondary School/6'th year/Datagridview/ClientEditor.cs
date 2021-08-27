using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datagridview
{
    public partial class ClientEditor : Form
    {
        private bool _isInsert;
        private MySqlHandler _mySqlHandler;
        private int _id;
        private Action _callback;

        public ClientEditor(MySqlHandler msh, Action callback)
        {
            InitializeComponent();
            this._mySqlHandler = msh;
            this._isInsert = true;
            btnAction.Text = "Create";
            this._callback = callback;
        }

        public ClientEditor(MySqlHandler msh, Action callback, string naam, string voornaam, string adress, int postcode, string gemeente, string tel, string geboortedatum, int id)
        {
            InitializeComponent();
            this._mySqlHandler = msh;
            this._isInsert = false;
            btnAction.Text = "Update";
            this._id = id;
            this._callback = callback;

            txtNaam.Text = naam;
            txtVnaam.Text = voornaam;
            txtAdress.Text = adress;
            txtPost.Text = postcode.ToString();
            txtGem.Text = gemeente;
            txtTel.Text = tel;
            dtpGeb.Text = geboortedatum;
        }

        private void btnCancel_Click(object sender, EventArgs e)
            => this.Close();

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaam.Text) || string.IsNullOrWhiteSpace(txtVnaam.Text) || string.IsNullOrWhiteSpace(txtAdress.Text) || 
                string.IsNullOrWhiteSpace(txtPost.Text) || string.IsNullOrWhiteSpace(txtGem.Text) || string.IsNullOrWhiteSpace(txtTel.Text))
            {
                MessageBox.Show("De niet alle velden zijn ingevuld!");
                return;
            }

            int postcode;
            if (!int.TryParse(txtPost.Text, out postcode))
            {
                MessageBox.Show("Geen valiede postcode.");
                return;
            }

            if ((DateTime.Now - dtpGeb.Value.AddYears(18)).TotalDays < 0)
            {
                MessageBox.Show("De gebruiker is onder de 18 jaar! En dat is niet toegestaan!");
                return;
            }

            string gebd = $"{dtpGeb.Value.Year}-{dtpGeb.Value.Month}-{dtpGeb.Value.Day}";
            MySqlCommand cmd;

            if (this._isInsert)
            {
                cmd = this._mySqlHandler.Prepare(MySQLStatements.InsertUser,
                    ("@Voornaam", txtVnaam.Text), ("@Naam", txtNaam.Text), ("@StraatNrBus", txtAdress.Text), ("@Postcode", postcode),
                    ("@Stad", txtGem.Text), ("@TelGSM", txtTel.Text), ("@Gebdatum", gebd));
            }
            else
            {
                cmd = this._mySqlHandler.Prepare(MySQLStatements.UpdateUser,
                    ("@Voornaam", txtVnaam.Text), ("@Naam", txtNaam.Text), ("@StraatNrBus", txtAdress.Text), ("@Postcode", postcode),
                    ("@Stad", txtGem.Text), ("@TelGSM", txtTel.Text), ("@Gebdatum", gebd), ("@id", this._id));
            }
            this._mySqlHandler.Execute(cmd);
            this.CloseWithUpdate();
        }

        private void CloseWithUpdate()
        {
            this._callback();
            this.Close();
        }
    }
}