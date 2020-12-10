namespace RadioRockNRoll
{
    partial class FrmSpelformulier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpelformulier));
            this.lblDagBericht = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSpelen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLuisteraar = new System.Windows.Forms.Label();
            this.txtGok = new System.Windows.Forms.TextBox();
            this.ptbZak = new System.Windows.Forms.PictureBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtPrijzen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbZak)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDagBericht
            // 
            this.lblDagBericht.AutoSize = true;
            this.lblDagBericht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDagBericht.Location = new System.Drawing.Point(12, 9);
            this.lblDagBericht.Name = "lblDagBericht";
            this.lblDagBericht.Size = new System.Drawing.Size(158, 25);
            this.lblDagBericht.TabIndex = 0;
            this.lblDagBericht.Text = "Dag <gebruiker>";
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(17, 68);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(271, 64);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(17, 138);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(271, 64);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nieuwe zak samenstellen";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSpelen
            // 
            this.btnSpelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpelen.Location = new System.Drawing.Point(17, 208);
            this.btnSpelen.Name = "btnSpelen";
            this.btnSpelen.Size = new System.Drawing.Size(271, 64);
            this.btnSpelen.TabIndex = 3;
            this.btnSpelen.Text = "Spel spelen";
            this.btnSpelen.UseVisualStyleBackColor = true;
            this.btnSpelen.Click += new System.EventHandler(this.btnSpelen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gok de waarde van de zak:";
            // 
            // lblLuisteraar
            // 
            this.lblLuisteraar.AutoSize = true;
            this.lblLuisteraar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuisteraar.Location = new System.Drawing.Point(17, 279);
            this.lblLuisteraar.Name = "lblLuisteraar";
            this.lblLuisteraar.Size = new System.Drawing.Size(52, 17);
            this.lblLuisteraar.TabIndex = 5;
            this.lblLuisteraar.Text = "label2";
            // 
            // txtGok
            // 
            this.txtGok.Location = new System.Drawing.Point(20, 350);
            this.txtGok.Name = "txtGok";
            this.txtGok.Size = new System.Drawing.Size(268, 22);
            this.txtGok.TabIndex = 6;
            this.txtGok.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerwerkGok);
            // 
            // ptbZak
            // 
            this.ptbZak.Image = ((System.Drawing.Image)(resources.GetObject("ptbZak.Image")));
            this.ptbZak.Location = new System.Drawing.Point(308, 9);
            this.ptbZak.Name = "ptbZak";
            this.ptbZak.Size = new System.Drawing.Size(362, 414);
            this.ptbZak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbZak.TabIndex = 7;
            this.ptbZak.TabStop = false;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(20, 378);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(268, 45);
            this.txtResponse.TabIndex = 8;
            // 
            // txtPrijzen
            // 
            this.txtPrijzen.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijzen.Location = new System.Drawing.Point(692, 13);
            this.txtPrijzen.Multiline = true;
            this.txtPrijzen.Name = "txtPrijzen";
            this.txtPrijzen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrijzen.Size = new System.Drawing.Size(687, 410);
            this.txtPrijzen.TabIndex = 9;
            // 
            // FrmSpelformulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 435);
            this.Controls.Add(this.txtPrijzen);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.ptbZak);
            this.Controls.Add(this.txtGok);
            this.Controls.Add(this.lblLuisteraar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpelen);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblDagBericht);
            this.Name = "FrmSpelformulier";
            this.Text = "De zak van de kerstman";
            ((System.ComponentModel.ISupportInitialize)(this.ptbZak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDagBericht;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSpelen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLuisteraar;
        private System.Windows.Forms.TextBox txtGok;
        private System.Windows.Forms.PictureBox ptbZak;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtPrijzen;
    }
}