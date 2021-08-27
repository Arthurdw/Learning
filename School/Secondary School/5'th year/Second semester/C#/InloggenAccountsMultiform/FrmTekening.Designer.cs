namespace InloggenAccountsMultiform
{
    partial class FrmTekening
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
            this.lblnaam = new System.Windows.Forms.Label();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(13, 13);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(35, 13);
            this.lblnaam.TabIndex = 0;
            this.lblnaam.Text = "label1";
            // 
            // pnlResult
            // 
            this.pnlResult.Location = new System.Drawing.Point(13, 48);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(400, 400);
            this.pnlResult.TabIndex = 1;
            this.pnlResult.Paint += new System.Windows.Forms.PaintEventHandler(this.tekenen);
            // 
            // FrmTekening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 462);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.lblnaam);
            this.Name = "FrmTekening";
            this.Text = "P O L Y G ON";
            this.Load += new System.EventHandler(this.FrmTekening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.Panel pnlResult;
    }
}