using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace AutoScreener
{
    public partial class ImageUpdater : Form
    {
        private readonly MySqlHandler _mySqlHandler;
        private string _selected;

        public ImageUpdater(MySqlHandler mySqlHandler)
        {
            InitializeComponent();
            this._mySqlHandler = mySqlHandler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string refId = txtRefId.Text.Trim();
            if (string.IsNullOrEmpty(refId))
            {
                MessageBox.Show(@"RefId was given.");
                return;
            }

            MySqlCommand cmd = this._mySqlHandler.Prepare(SqlStatements.FetchStatement, ("@refnr", refId));

            this._mySqlHandler._connection.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                byte[] data = (byte[])rdr[0];
                if (data == null)
                {
                    MessageBox.Show(@"Invalid RefId", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ptbPreview.Image = new Bitmap(ImageHandler.BytesToImage(data), new Size(ptbPreview.Width, ptbPreview.Height));
                this._selected = refId;
                break;
            }
            rdr.Close();
            this._mySqlHandler._connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this._selected == null)
            {
                MessageBox.Show(@"Gelieve eerst een bestand te fetchen!");
                return;
            }

            FileDialogHandler fdh = new FileDialogHandler();
            fdh.Filter = "Image files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg|" + fdh.Filter;
            string selectedFilePath = fdh.OpenFileSelector();

            if (!File.Exists(selectedFilePath))
            {
                MessageBox.Show(@"Je hebt geen bestand geselecteerd!");
                return;
            }

            this.UpdateSelectedImage(Image.FromFile(selectedFilePath));
            MessageBox.Show(@"Successfully updated the image!");
        }

        private void UpdateSelectedImage(Image img)
        {
            MySqlCommand cmd = this._mySqlHandler.Prepare(
                SqlStatements.UpdateImageStatement,
                ("@id", this._selected),
                ("@image", ImageHandler.ImageToBytes(img, ImageFormat.Png)));
            this._mySqlHandler.Execute(cmd);
        }

        private void btnRename_Click(object sender, EventArgs e)
            => new ImageRenamer(this._mySqlHandler, this._selected).Show();
    }
}