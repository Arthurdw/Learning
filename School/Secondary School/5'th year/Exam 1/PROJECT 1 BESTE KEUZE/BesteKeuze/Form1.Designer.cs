namespace BesteKeuze
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
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnlinks = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRechts
            // 
            this.btnRechts.BackgroundImage = global::BesteKeuze.Properties.Resources._1;
            this.btnRechts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechts.Location = new System.Drawing.Point(361, 70);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(304, 358);
            this.btnRechts.TabIndex = 1;
            this.btnRechts.UseVisualStyleBackColor = true;
            // 
            // btnlinks
            // 
            this.btnlinks.BackgroundImage = global::BesteKeuze.Properties.Resources._2;
            this.btnlinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlinks.Location = new System.Drawing.Point(37, 70);
            this.btnlinks.Name = "btnlinks";
            this.btnlinks.Size = new System.Drawing.Size(304, 358);
            this.btnlinks.TabIndex = 0;
            this.btnlinks.UseVisualStyleBackColor = true;
            this.btnlinks.Click += new System.EventHandler(this.Btnlinks_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Gray;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(508, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(157, 37);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nieuwe keuze";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnlinks);
            this.Name = "Form1";
            this.Text = "WAT VERKIES JE?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlinks;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnNew;
    }
}

