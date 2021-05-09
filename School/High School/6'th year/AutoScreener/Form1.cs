// ©Arthurdw | GO-AO

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AutoScreener
{
    public partial class Form1 : Form
    {
        private int _currentIndex;
        private List<Image> _currentImages;
        private MySqlHandler _mySqlHandler;

        public Form1()
        {
            InitializeComponent();
            this.InitializeProgram();
        }

        private void InitializeProgram()
        {
            this._mySqlHandler = new MySqlHandler(MySqlClient.From(
                "username",
                "password",
                "database",
                "arthur.go-ao.be"));

            _currentImages = new List<Image>();
            ChangeGameState(false);
            for (int i = 0; i < 15; i++)
            {
                Button btn = new Button()
                {
                    Dock = DockStyle.Fill,
                    BackgroundImageLayout = ImageLayout.Stretch
                };

                btn.Click += this.SelectImage;

                tlpScreens.Controls.Add(btn);
            }

            tsmiSave.Enabled = false;
        }

        private void ChangeGameState(bool started)
        {
            tsmiStart.Enabled = !started;
            tsmiStop.Enabled = started;
            if (started) timer.Start();
            else timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this._currentIndex == 15) this.ChangeGameState(true);
            else this.ProceedToCapture();
        }

        private void ProceedToCapture()
        {
            Bitmap bm = new Bitmap(800, 800);
            Graphics g = Graphics.FromImage(bm);
            Point p = new Point(50, 20);
            g.CopyFromScreen(p, new Point(0, 0), bm.Size);
            this.SetPreview((Image)bm);
        }

        private void SetPreview(Image bm)
        {
            Control ctrl = tlpScreens.Controls[this._currentIndex];
            ctrl.BackgroundImage = bm;
            this._currentIndex++;
        }

        private void tsmiStart_Click(object sender, EventArgs e)
            => this.ChangeGameState(true);

        private void tsmiStop_Click(object sender, EventArgs e)
            => this.ChangeGameState(false);

        private void tsmiReset_Click(object sender, EventArgs e)
        {
            this.ChangeGameState(false);
            this._currentIndex = 0;
            foreach (Button btn in tlpScreens.Controls)
                btn.BackgroundImage = null;
        }

        private void SelectImage(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackgroundImage == null) return;

            if (btn.Text == @"Selected")
            {
                btn.Text = String.Empty;
                this._currentImages.Remove(btn.BackgroundImage);
            }
            else
            {
                btn.Text = @"Selected";
                this._currentImages.Add(btn.BackgroundImage);
            }
            tsmiSave.Enabled = this._currentImages.Count != 0;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            foreach (Image image in this._currentImages)
                this.SaveImage(image);

            MessageBox.Show(@"Successfully saved the images to the database.");
        }

        private void SaveImage(Image img)
        {
            string id = "" + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Second + DateTime.Now.Millisecond;
            MySqlCommand cmd = this._mySqlHandler.Prepare(
                SqlStatements.InsertStatement,
                ("@id", id),
                ("@image", ImageHandler.ImageToBytes(img, ImageFormat.Png)));
            this._mySqlHandler.Execute(cmd);
        }

        private void tsmiEditImages_Click(object sender, EventArgs e)
            => new ImageUpdater(this._mySqlHandler).Show();
    }
}