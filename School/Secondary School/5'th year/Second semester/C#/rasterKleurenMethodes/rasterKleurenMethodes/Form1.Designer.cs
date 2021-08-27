namespace rasterKleurenMethodes
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
            this.btnTomato = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnLime = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTomato
            // 
            this.btnTomato.Location = new System.Drawing.Point(13, 13);
            this.btnTomato.Name = "btnTomato";
            this.btnTomato.Size = new System.Drawing.Size(75, 23);
            this.btnTomato.TabIndex = 0;
            this.btnTomato.Text = "Tomato";
            this.btnTomato.UseVisualStyleBackColor = true;
            this.btnTomato.Click += new System.EventHandler(this.btnTomato_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(175, 13);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnLime
            // 
            this.btnLime.Location = new System.Drawing.Point(94, 13);
            this.btnLime.Name = "btnLime";
            this.btnLime.Size = new System.Drawing.Size(75, 23);
            this.btnLime.TabIndex = 2;
            this.btnLime.Text = "Lime";
            this.btnLime.UseVisualStyleBackColor = true;
            this.btnLime.Click += new System.EventHandler(this.btnLime_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.Location = new System.Drawing.Point(13, 43);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(237, 124);
            this.pnlShow.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 182);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.btnLime);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnTomato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTomato;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnLime;
        private System.Windows.Forms.Panel pnlShow;
    }
}

