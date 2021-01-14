
namespace Blobs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.txtFetchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowLast
            // 
            this.btnShowLast.Location = new System.Drawing.Point(10, 278);
            this.btnShowLast.Name = "btnShowLast";
            this.btnShowLast.Size = new System.Drawing.Size(193, 35);
            this.btnShowLast.TabIndex = 11;
            this.btnShowLast.Text = "Show last";
            this.btnShowLast.UseVisualStyleBackColor = true;
            this.btnShowLast.Click += new System.EventHandler(this.btnShowLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(163, 38);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(40, 40);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // ptbImage
            // 
            this.ptbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ptbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbImage.Location = new System.Drawing.Point(10, 38);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(193, 193);
            this.ptbImage.TabIndex = 8;
            this.ptbImage.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(150, 319);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(53, 35);
            this.btnFetch.TabIndex = 12;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // txtFetchName
            // 
            this.txtFetchName.Location = new System.Drawing.Point(12, 327);
            this.txtFetchName.Name = "txtFetchName";
            this.txtFetchName.Size = new System.Drawing.Size(132, 20);
            this.txtFetchName.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 360);
            this.Controls.Add(this.txtFetchName);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnShowLast);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Blobs Panel";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowLast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtFetchName;
    }
}

