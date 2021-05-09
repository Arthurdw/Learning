using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AutoScreener
{
    public sealed partial class ImageRenamer : Form
    {
        private readonly MySqlHandler _mySqlHandler;
        private readonly string _image;

        public ImageRenamer(MySqlHandler sqlHandler, string image)
        {
            InitializeComponent();
            this._mySqlHandler = sqlHandler;
            this._image = image;
            this.Text = $@"Hernoem {image}";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(@"Er werd geen naam opgegeven.");
                return;
            }
            RenameImage(name);
            this.Close();
        }

        private void RenameImage(string newName)
        {
            MySqlCommand cmd = this._mySqlHandler.Prepare(SqlStatements.UpdateTextStatement,
                ("@newId", newName), ("@id", this._image));
            this._mySqlHandler.Execute(cmd);
        }
    }
}