namespace Seasons {
    partial class Seasons {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seasons));
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.ptb_main = new System.Windows.Forms.PictureBox();
            this.btn_north = new System.Windows.Forms.Button();
            this.btn_south = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_main)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kies een datum:";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.dtp_date.Location = new System.Drawing.Point(168, -6);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(452, 32);
            this.dtp_date.TabIndex = 1;
            this.dtp_date.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // ptb_main
            // 
            this.ptb_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptb_main.Image = ((System.Drawing.Image)(resources.GetObject("ptb_main.Image")));
            this.ptb_main.Location = new System.Drawing.Point(0, 26);
            this.ptb_main.Name = "ptb_main";
            this.ptb_main.Size = new System.Drawing.Size(526, 377);
            this.ptb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_main.TabIndex = 2;
            this.ptb_main.TabStop = false;
            // 
            // btn_north
            // 
            this.btn_north.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.btn_north.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_north.ForeColor = System.Drawing.Color.Black;
            this.btn_north.Location = new System.Drawing.Point(525, 24);
            this.btn_north.Margin = new System.Windows.Forms.Padding(0);
            this.btn_north.Name = "btn_north";
            this.btn_north.Size = new System.Drawing.Size(94, 191);
            this.btn_north.TabIndex = 3;
            this.btn_north.Text = "Noordelijk Halfrond";
            this.btn_north.UseVisualStyleBackColor = false;
            this.btn_north.Click += new System.EventHandler(this.Btn_north_Click);
            // 
            // btn_south
            // 
            this.btn_south.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_south.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_south.ForeColor = System.Drawing.Color.White;
            this.btn_south.Location = new System.Drawing.Point(525, 212);
            this.btn_south.Margin = new System.Windows.Forms.Padding(0);
            this.btn_south.Name = "btn_south";
            this.btn_south.Size = new System.Drawing.Size(94, 191);
            this.btn_south.TabIndex = 4;
            this.btn_south.Text = "Zuidelijk Halfrond";
            this.btn_south.UseVisualStyleBackColor = false;
            this.btn_south.Click += new System.EventHandler(this.Btn_south_Click);
            // 
            // Seasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 397);
            this.Controls.Add(this.btn_south);
            this.Controls.Add(this.btn_north);
            this.Controls.Add(this.ptb_main);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seasons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seasons";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.PictureBox ptb_main;
        private System.Windows.Forms.Button btn_north;
        private System.Windows.Forms.Button btn_south;
    }
}

