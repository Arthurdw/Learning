namespace Tekenles1
{
    partial class Tekenles
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
            this.BTNToon = new System.Windows.Forms.Button();
            this.PNLTekening = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BTNToon
            // 
            this.BTNToon.Location = new System.Drawing.Point(12, 12);
            this.BTNToon.Name = "BTNToon";
            this.BTNToon.Size = new System.Drawing.Size(776, 23);
            this.BTNToon.TabIndex = 0;
            this.BTNToon.Text = "TOON TEKENING";
            this.BTNToon.UseVisualStyleBackColor = true;
            this.BTNToon.Click += new System.EventHandler(this.BTNToon_Click);
            // 
            // PNLTekening
            // 
            this.PNLTekening.Location = new System.Drawing.Point(13, 42);
            this.PNLTekening.Name = "PNLTekening";
            this.PNLTekening.Size = new System.Drawing.Size(775, 396);
            this.PNLTekening.TabIndex = 1;
            // 
            // Tekenles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNLTekening);
            this.Controls.Add(this.BTNToon);
            this.Name = "Tekenles";
            this.Text = "Tekenles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNToon;
        private System.Windows.Forms.Panel PNLTekening;
    }
}

