namespace Array1RandomGetallen
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
            this.btnVullen = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVullen
            // 
            this.btnVullen.Location = new System.Drawing.Point(13, 13);
            this.btnVullen.Name = "btnVullen";
            this.btnVullen.Size = new System.Drawing.Size(136, 23);
            this.btnVullen.TabIndex = 0;
            this.btnVullen.Text = "Array Invullen";
            this.btnVullen.UseVisualStyleBackColor = true;
            this.btnVullen.Click += new System.EventHandler(this.BtnVullen_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.Location = new System.Drawing.Point(13, 42);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(136, 23);
            this.btnTonen.TabIndex = 1;
            this.btnTonen.Text = "Array Tonen";
            this.btnTonen.UseVisualStyleBackColor = true;
            this.btnTonen.Click += new System.EventHandler(this.BtnTonen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 86);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.btnVullen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVullen;
        private System.Windows.Forms.Button btnTonen;
    }
}

