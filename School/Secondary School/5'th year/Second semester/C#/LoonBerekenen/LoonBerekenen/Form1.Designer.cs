namespace LoonBerekenen
{
    partial class Loonberekenen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIGewoon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMINacht = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIVerplaatsing = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIWeekend = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUuroon = new System.Windows.Forms.Label();
            this.lblGewerkt = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtUurloon = new System.Windows.Forms.TextBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.txtLoon = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIGewoon,
            this.TSMINacht,
            this.TSMIVerplaatsing,
            this.TSMIWeekend});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIGewoon
            // 
            this.TSMIGewoon.Name = "TSMIGewoon";
            this.TSMIGewoon.Size = new System.Drawing.Size(115, 24);
            this.TSMIGewoon.Text = "Gewoon Loon";
            this.TSMIGewoon.Click += new System.EventHandler(this.TSMIGewoon_Click);
            // 
            // TSMINacht
            // 
            this.TSMINacht.Name = "TSMINacht";
            this.TSMINacht.Size = new System.Drawing.Size(97, 24);
            this.TSMINacht.Text = "Nachttarief";
            this.TSMINacht.Click += new System.EventHandler(this.TSMINacht_Click);
            // 
            // TSMIVerplaatsing
            // 
            this.TSMIVerplaatsing.Name = "TSMIVerplaatsing";
            this.TSMIVerplaatsing.Size = new System.Drawing.Size(142, 24);
            this.TSMIVerplaatsing.Text = "Extra Verplaatsing";
            this.TSMIVerplaatsing.Click += new System.EventHandler(this.TSMIVerplaatsing_Click);
            // 
            // TSMIWeekend
            // 
            this.TSMIWeekend.Name = "TSMIWeekend";
            this.TSMIWeekend.Size = new System.Drawing.Size(84, 24);
            this.TSMIWeekend.Text = "Weekend";
            this.TSMIWeekend.Click += new System.EventHandler(this.TSMIWeekend_Click);
            // 
            // lblUuroon
            // 
            this.lblUuroon.AutoSize = true;
            this.lblUuroon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblUuroon.Location = new System.Drawing.Point(13, 43);
            this.lblUuroon.Name = "lblUuroon";
            this.lblUuroon.Size = new System.Drawing.Size(110, 30);
            this.lblUuroon.TabIndex = 1;
            this.lblUuroon.Text = "Uurloon:";
            // 
            // lblGewerkt
            // 
            this.lblGewerkt.AutoSize = true;
            this.lblGewerkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblGewerkt.Location = new System.Drawing.Point(13, 93);
            this.lblGewerkt.Name = "lblGewerkt";
            this.lblGewerkt.Size = new System.Drawing.Size(141, 30);
            this.lblGewerkt.TabIndex = 2;
            this.lblGewerkt.Text = "Aantal Uur:";
            // 
            // txtAantal
            // 
            this.txtAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtAantal.Location = new System.Drawing.Point(184, 89);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(288, 37);
            this.txtAantal.TabIndex = 3;
            // 
            // txtUurloon
            // 
            this.txtUurloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtUurloon.Location = new System.Drawing.Point(184, 39);
            this.txtUurloon.Name = "txtUurloon";
            this.txtUurloon.Size = new System.Drawing.Size(288, 37);
            this.txtUurloon.TabIndex = 4;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTotaal.Location = new System.Drawing.Point(13, 187);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(146, 30);
            this.lblTotaal.TabIndex = 5;
            this.lblTotaal.Text = "Totaal loon:";
            // 
            // txtLoon
            // 
            this.txtLoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtLoon.Location = new System.Drawing.Point(184, 183);
            this.txtLoon.Name = "txtLoon";
            this.txtLoon.Size = new System.Drawing.Size(288, 37);
            this.txtLoon.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(184, 160);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "(status)";
            // 
            // Loonberekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 233);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLoon);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.txtUurloon);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lblGewerkt);
            this.Controls.Add(this.lblUuroon);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Loonberekenen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loon Berekener";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIGewoon;
        private System.Windows.Forms.ToolStripMenuItem TSMINacht;
        private System.Windows.Forms.ToolStripMenuItem TSMIVerplaatsing;
        private System.Windows.Forms.ToolStripMenuItem TSMIWeekend;
        private System.Windows.Forms.Label lblUuroon;
        private System.Windows.Forms.Label lblGewerkt;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtUurloon;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.TextBox txtLoon;
        private System.Windows.Forms.Label lblStatus;
    }
}

