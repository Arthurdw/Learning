namespace TekstLus1
{
    partial class Fill
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
            this.btnFill = new System.Windows.Forms.Button();
            this.txtFill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnFill.Location = new System.Drawing.Point(12, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(776, 49);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "Vul";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // txtFill
            // 
            this.txtFill.Location = new System.Drawing.Point(12, 67);
            this.txtFill.Multiline = true;
            this.txtFill.Name = "txtFill";
            this.txtFill.ReadOnly = true;
            this.txtFill.Size = new System.Drawing.Size(776, 371);
            this.txtFill.TabIndex = 1;
            // 
            // Fill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFill);
            this.Controls.Add(this.btnFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.TextBox txtFill;
    }
}

