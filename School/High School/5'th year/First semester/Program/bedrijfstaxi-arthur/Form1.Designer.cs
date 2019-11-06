namespace bedrijfstaxi_arthur
{
    partial class TAXI
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
            this.txtaantalbezoekers = new System.Windows.Forms.Label();
            this.calcbutton = new System.Windows.Forms.Button();
            this.txtbezoekersaantal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox12 = new System.Windows.Forms.TextBox();
            this.txtboxlaatste = new System.Windows.Forms.TextBox();
            this.txtbox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtaantalbezoekers
            // 
            this.txtaantalbezoekers.AutoSize = true;
            this.txtaantalbezoekers.Location = new System.Drawing.Point(13, 13);
            this.txtaantalbezoekers.Name = "txtaantalbezoekers";
            this.txtaantalbezoekers.Size = new System.Drawing.Size(89, 13);
            this.txtaantalbezoekers.TabIndex = 0;
            this.txtaantalbezoekers.Text = "Aantal bezoekers";
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(16, 42);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(254, 33);
            this.calcbutton.TabIndex = 1;
            this.calcbutton.Text = "Voertuigen bepalen";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
            // 
            // txtbezoekersaantal
            // 
            this.txtbezoekersaantal.Location = new System.Drawing.Point(108, 10);
            this.txtbezoekersaantal.Name = "txtbezoekersaantal";
            this.txtbezoekersaantal.Size = new System.Drawing.Size(61, 20);
            this.txtbezoekersaantal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voertuigen:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aantal 12 passagiers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aantal passagiers laatste auto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aantal 4 passagiers:";
            // 
            // txtbox12
            // 
            this.txtbox12.Location = new System.Drawing.Point(170, 149);
            this.txtbox12.Name = "txtbox12";
            this.txtbox12.Size = new System.Drawing.Size(100, 20);
            this.txtbox12.TabIndex = 8;
            // 
            // txtboxlaatste
            // 
            this.txtboxlaatste.Location = new System.Drawing.Point(170, 216);
            this.txtboxlaatste.Name = "txtboxlaatste";
            this.txtboxlaatste.Size = new System.Drawing.Size(100, 20);
            this.txtboxlaatste.TabIndex = 9;
            // 
            // txtbox4
            // 
            this.txtbox4.Location = new System.Drawing.Point(170, 179);
            this.txtbox4.Name = "txtbox4";
            this.txtbox4.Size = new System.Drawing.Size(100, 20);
            this.txtbox4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bedrijfstaxi_arthur.Properties.Resources.personenauto_leasen_leaseofferte_com;
            this.pictureBox1.Location = new System.Drawing.Point(276, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TAXI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox4);
            this.Controls.Add(this.txtboxlaatste);
            this.Controls.Add(this.txtbox12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbezoekersaantal);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.txtaantalbezoekers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TAXI";
            this.Text = "T A X I";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtaantalbezoekers;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.TextBox txtbezoekersaantal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox12;
        private System.Windows.Forms.TextBox txtboxlaatste;
        private System.Windows.Forms.TextBox txtbox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

