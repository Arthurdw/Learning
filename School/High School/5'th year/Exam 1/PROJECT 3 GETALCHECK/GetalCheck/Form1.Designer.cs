namespace GetalCheck {
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
            this.txtinvoer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pbRes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtinvoer
            // 
            this.txtinvoer.Location = new System.Drawing.Point(13, 13);
            this.txtinvoer.Name = "txtinvoer";
            this.txtinvoer.Size = new System.Drawing.Size(404, 20);
            this.txtinvoer.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(13, 39);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(404, 36);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "valideer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // pbRes
            // 
            this.pbRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbRes.Location = new System.Drawing.Point(13, 90);
            this.pbRes.Name = "pbRes";
            this.pbRes.Size = new System.Drawing.Size(404, 269);
            this.pbRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRes.TabIndex = 2;
            this.pbRes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 371);
            this.Controls.Add(this.pbRes);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtinvoer);
            this.Name = "Form1";
            this.Text = "C H E C K G E T A L";
            ((System.ComponentModel.ISupportInitialize)(this.pbRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinvoer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pbRes;
    }
}

