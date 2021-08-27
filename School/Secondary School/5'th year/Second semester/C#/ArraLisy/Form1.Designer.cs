namespace ArraLisy
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
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.lbgdn = new System.Windows.Forms.ListBox();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.Location = new System.Drawing.Point(13, 13);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(120, 95);
            this.lbProducten.TabIndex = 0;
            // 
            // lbgdn
            // 
            this.lbgdn.FormattingEnabled = true;
            this.lbgdn.Location = new System.Drawing.Point(221, 13);
            this.lbgdn.Name = "lbgdn";
            this.lbgdn.Size = new System.Drawing.Size(120, 95);
            this.lbgdn.TabIndex = 1;
            // 
            // btnToRight
            // 
            this.btnToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnToRight.Location = new System.Drawing.Point(140, 13);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(75, 44);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = "-->";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.BtnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnToLeft.Location = new System.Drawing.Point(140, 63);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 45);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "<--";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.BtnToLeft_Click);
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(13, 115);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(0, 13);
            this.lblTotaal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 140);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.lbgdn);
            this.Controls.Add(this.lbProducten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.ListBox lbgdn;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.Label lblTotaal;
    }
}

