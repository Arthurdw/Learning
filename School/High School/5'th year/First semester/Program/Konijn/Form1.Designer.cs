namespace Konijn
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
            this.BTNStart = new System.Windows.Forms.Button();
            this.PNLToon = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BTNStart
            // 
            this.BTNStart.Location = new System.Drawing.Point(22, 12);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(565, 37);
            this.BTNStart.TabIndex = 0;
            this.BTNStart.Text = "TOON TEKENING";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // PNLToon
            // 
            this.PNLToon.Location = new System.Drawing.Point(22, 55);
            this.PNLToon.Name = "PNLToon";
            this.PNLToon.Size = new System.Drawing.Size(565, 772);
            this.PNLToon.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(599, 839);
            this.Controls.Add(this.PNLToon);
            this.Controls.Add(this.BTNStart);
            this.Name = "Form1";
            this.Text = "Een lief klein konijntje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Panel PNLToon;
    }
}

