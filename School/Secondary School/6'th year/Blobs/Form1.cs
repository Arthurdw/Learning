// ©Arthurdw | GO-Atheneum Oudenaarde
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Blobs
{
    public partial class Form1 : Form
    {
        private readonly DataHandler _dh = new DataHandler("userName", "password", "06InfoArthur", "arthur.go-ao.be", "3306");
        private string _imagePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs eventArgs)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "image files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this._imagePath = ofd.FileName;
                    ptbImage.BackgroundImage = Image.FromFile(this._imagePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs eventArgs)
        {
            bool noName = string.IsNullOrWhiteSpace(txtName.Text);
            bool noImage = ptbImage.BackgroundImage == null;
            if (noName || noImage)
            {
                MessageBox.Show(noName ? @"Oops... No image name was provided!" : @"Oops... No image was provided!");
                return;
            }

            try
            {
                // FileStream fs = new FileStream(this.ImagePath, FileMode.Open, FileAccess.Read);
                // BinaryReader br = new BinaryReader(fs);
                //
                // byte[] data = br.ReadBytes((int)fs.Length);
                //
                // br.Close();
                // fs.Close();

                // MemoryStream ms = new MemoryStream();
                // Bitmap bm = new Bitmap(ptbImage.BackgroundImage);
                // bm.Save(ms, ptbImage.BackgroundImage.RawFormat);
                // byte[] data = ms.ToArray();
                // ms.Dispose();

                this._dh.Execute(txtName.Text, GetImageBytes(ptbImage.BackgroundImage));

                txtName.Text = string.Empty;
                ptbImage.BackgroundImage = null;
                MessageBox.Show("Successfully created the blob object!", "Yey!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show(
                    "Something went wrong while trying to execute the create blob statement. (maybe invalid credentials?)");
            }
            catch (InvalidExecuteException e)
            {
                switch (e.Message)
                {
                    case "No rows got changed":
                        MessageBox.Show("I couldn't create the record... (No rows changed)");
                        break;

                    default:
                        MessageBox.Show("Something went wrong with our sql execution!");
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Oops... (Unknown exception)");
            }
        }

        private byte[] GetImageBytes(Image ico)
        {
            using (var ms = new MemoryStream())
            {
                ico.Save(ms, ico.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnShowLast_Click(object sender, EventArgs e)
        {
            BlobsImage img = this._dh.GetLatestBlobsImage();
            ptbImage.BackgroundImage = img.Img;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string name = txtFetchName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(@"Oops... No image name was provided!");
                return;
            }
            BlobsImage img = this._dh.GetSpecificBlobsImage(name);

            if (img != null)
            {
                ptbImage.BackgroundImage = img.Img;
                txtFetchName.Clear();
            }
            else MessageBox.Show(@"No image found with that name!");
        }
    }
}