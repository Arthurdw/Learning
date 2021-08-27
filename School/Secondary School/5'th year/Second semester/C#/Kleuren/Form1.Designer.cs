namespace Kleuren
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBColors = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welke kleur zal er verschijnen?";
            // 
            // CBColors
            // 
            this.CBColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBColors.FormattingEnabled = true;
            this.CBColors.Location = new System.Drawing.Point(17, 36);
            this.CBColors.Name = "CBColors";
            this.CBColors.Size = new System.Drawing.Size(238, 28);
            this.CBColors.TabIndex = 1;
            this.CBColors.SelectedIndexChanged += new System.EventHandler(this.CBColors_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtStatus.Location = new System.Drawing.Point(284, 13);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(368, 26);
            this.txtStatus.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtLog.Location = new System.Drawing.Point(284, 45);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(368, 393);
            this.txtLog.TabIndex = 3;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Location = new System.Drawing.Point(17, 71);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(229, 367);
            this.pnlDisplay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.CBColors);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RAADSPEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBColors;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel pnlDisplay;
    }
}

