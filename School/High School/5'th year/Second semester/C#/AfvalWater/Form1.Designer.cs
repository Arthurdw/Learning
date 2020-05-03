namespace AfvalWater
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.lblLading = new System.Windows.Forms.Label();
            this.lblStand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(181, 26);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nieuwe lading";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btntest
            // 
            this.btntest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btntest.Location = new System.Drawing.Point(200, 13);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(62, 51);
            this.btntest.TabIndex = 1;
            this.btntest.Text = "test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.Btntest_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.Location = new System.Drawing.Point(12, 70);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(250, 500);
            this.pnlShow.TabIndex = 2;
            // 
            // lblLading
            // 
            this.lblLading.AutoSize = true;
            this.lblLading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblLading.ForeColor = System.Drawing.Color.White;
            this.lblLading.Location = new System.Drawing.Point(12, 42);
            this.lblLading.Name = "lblLading";
            this.lblLading.Size = new System.Drawing.Size(84, 25);
            this.lblLading.TabIndex = 3;
            this.lblLading.Text = "(lading)";
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblStand.ForeColor = System.Drawing.Color.White;
            this.lblStand.Location = new System.Drawing.Point(12, 573);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(131, 25);
            this.lblStand.TabIndex = 4;
            this.lblStand.Text = "(waterstand)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(283, 605);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.lblLading);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.btnNew);
            this.Name = "Form1";
            this.Text = "Opvang Afvalwater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Label lblLading;
        private System.Windows.Forms.Label lblStand;
    }
}

