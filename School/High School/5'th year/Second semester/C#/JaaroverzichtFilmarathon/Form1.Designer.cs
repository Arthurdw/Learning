namespace JaaroverzichtFilmarathon
{
    partial class GrafisheArrays
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
            this.btnWeergeven = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnWeergeven
            // 
            this.btnWeergeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnWeergeven.Location = new System.Drawing.Point(13, 12);
            this.btnWeergeven.Name = "btnWeergeven";
            this.btnWeergeven.Size = new System.Drawing.Size(34, 496);
            this.btnWeergeven.TabIndex = 0;
            this.btnWeergeven.Text = "Weergeven";
            this.btnWeergeven.UseVisualStyleBackColor = true;
            this.btnWeergeven.Click += new System.EventHandler(this.BtnWeergeven_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Location = new System.Drawing.Point(53, 13);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(750, 500);
            this.pnlDisplay.TabIndex = 1;
            // 
            // GrafisheArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(811, 520);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.btnWeergeven);
            this.Name = "GrafisheArrays";
            this.Text = "Film marathorn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeergeven;
        private System.Windows.Forms.Panel pnlDisplay;
    }
}

