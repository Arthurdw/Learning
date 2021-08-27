namespace Bacterien
{
    partial class Bacterien
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblBact = new System.Windows.Forms.Label();
            this.lblEind = new System.Windows.Forms.Label();
            this.lblBactEind = new System.Windows.Forms.Label();
            this.txtStartUur = new System.Windows.Forms.TextBox();
            this.txtAantalBactStart = new System.Windows.Forms.TextBox();
            this.txtEindUur = new System.Windows.Forms.TextBox();
            this.txtAantalBactEinde = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblStart.Location = new System.Drawing.Point(12, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(94, 25);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Startuur:";
            // 
            // lblBact
            // 
            this.lblBact.AutoSize = true;
            this.lblBact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblBact.Location = new System.Drawing.Point(12, 59);
            this.lblBact.Name = "lblBact";
            this.lblBact.Size = new System.Drawing.Size(174, 25);
            this.lblBact.TabIndex = 1;
            this.lblBact.Text = "Aantal bacteriën:";
            // 
            // lblEind
            // 
            this.lblEind.AutoSize = true;
            this.lblEind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblEind.Location = new System.Drawing.Point(12, 109);
            this.lblEind.Name = "lblEind";
            this.lblEind.Size = new System.Drawing.Size(92, 25);
            this.lblEind.TabIndex = 3;
            this.lblEind.Text = "Einduur:";
            // 
            // lblBactEind
            // 
            this.lblBactEind.AutoSize = true;
            this.lblBactEind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblBactEind.Location = new System.Drawing.Point(12, 159);
            this.lblBactEind.Name = "lblBactEind";
            this.lblBactEind.Size = new System.Drawing.Size(176, 25);
            this.lblBactEind.TabIndex = 4;
            this.lblBactEind.Text = "Aantal Bacterien:";
            // 
            // txtStartUur
            // 
            this.txtStartUur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtStartUur.Location = new System.Drawing.Point(194, 9);
            this.txtStartUur.Name = "txtStartUur";
            this.txtStartUur.Size = new System.Drawing.Size(122, 31);
            this.txtStartUur.TabIndex = 5;
            // 
            // txtAantalBactStart
            // 
            this.txtAantalBactStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtAantalBactStart.Location = new System.Drawing.Point(194, 59);
            this.txtAantalBactStart.Name = "txtAantalBactStart";
            this.txtAantalBactStart.Size = new System.Drawing.Size(122, 31);
            this.txtAantalBactStart.TabIndex = 6;
            // 
            // txtEindUur
            // 
            this.txtEindUur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtEindUur.Location = new System.Drawing.Point(194, 109);
            this.txtEindUur.Name = "txtEindUur";
            this.txtEindUur.Size = new System.Drawing.Size(122, 31);
            this.txtEindUur.TabIndex = 7;
            // 
            // txtAantalBactEinde
            // 
            this.txtAantalBactEinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtAantalBactEinde.Location = new System.Drawing.Point(194, 159);
            this.txtAantalBactEinde.Name = "txtAantalBactEinde";
            this.txtAantalBactEinde.Size = new System.Drawing.Size(122, 31);
            this.txtAantalBactEinde.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(322, 9);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(251, 435);
            this.txtResult.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnShow.Location = new System.Drawing.Point(12, 206);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(304, 72);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "TOON GROEI";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Bacterien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAantalBactEinde);
            this.Controls.Add(this.txtEindUur);
            this.Controls.Add(this.txtAantalBactStart);
            this.Controls.Add(this.txtStartUur);
            this.Controls.Add(this.lblBactEind);
            this.Controls.Add(this.lblEind);
            this.Controls.Add(this.lblBact);
            this.Controls.Add(this.lblStart);
            this.Name = "Bacterien";
            this.Text = "Bacteriën";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblBact;
        private System.Windows.Forms.Label lblEind;
        private System.Windows.Forms.Label lblBactEind;
        private System.Windows.Forms.TextBox txtStartUur;
        private System.Windows.Forms.TextBox txtAantalBactStart;
        private System.Windows.Forms.TextBox txtEindUur;
        private System.Windows.Forms.TextBox txtAantalBactEinde;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnShow;
    }
}

