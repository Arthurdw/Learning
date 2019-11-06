namespace afbeeldingen {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_play = new System.Windows.Forms.Button();
            this.ptb_1 = new System.Windows.Forms.PictureBox();
            this.ptb_2 = new System.Windows.Forms.PictureBox();
            this.ptb_3 = new System.Windows.Forms.PictureBox();
            this.lbl_out = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btn_play.Location = new System.Drawing.Point(12, 12);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(708, 50);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.Btn_play_Click);
            // 
            // ptb_1
            // 
            this.ptb_1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_1.Image")));
            this.ptb_1.Location = new System.Drawing.Point(12, 68);
            this.ptb_1.Name = "ptb_1";
            this.ptb_1.Size = new System.Drawing.Size(236, 188);
            this.ptb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_1.TabIndex = 1;
            this.ptb_1.TabStop = false;
            // 
            // ptb_2
            // 
            this.ptb_2.Image = ((System.Drawing.Image)(resources.GetObject("ptb_2.Image")));
            this.ptb_2.Location = new System.Drawing.Point(248, 68);
            this.ptb_2.Name = "ptb_2";
            this.ptb_2.Size = new System.Drawing.Size(236, 188);
            this.ptb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_2.TabIndex = 2;
            this.ptb_2.TabStop = false;
            // 
            // ptb_3
            // 
            this.ptb_3.Image = ((System.Drawing.Image)(resources.GetObject("ptb_3.Image")));
            this.ptb_3.Location = new System.Drawing.Point(484, 68);
            this.ptb_3.Name = "ptb_3";
            this.ptb_3.Size = new System.Drawing.Size(236, 188);
            this.ptb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_3.TabIndex = 3;
            this.ptb_3.TabStop = false;
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_out.Location = new System.Drawing.Point(12, 259);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(151, 39);
            this.lbl_out.TabIndex = 5;
            this.lbl_out.Text = "<output>";
            this.lbl_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 264);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.ptb_3);
            this.Controls.Add(this.ptb_2);
            this.Controls.Add(this.ptb_1);
            this.Controls.Add(this.btn_play);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trio Afbeeldingen";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.PictureBox ptb_1;
        private System.Windows.Forms.PictureBox ptb_2;
        private System.Windows.Forms.PictureBox ptb_3;
        private System.Windows.Forms.Label lbl_out;
    }
}

