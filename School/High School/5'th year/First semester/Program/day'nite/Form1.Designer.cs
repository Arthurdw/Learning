namespace day_nite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_gen = new System.Windows.Forms.Button();
            this.txt_minuten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_licht_or_donker = new System.Windows.Forms.Label();
            this.afbeelding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.afbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_gen.Location = new System.Drawing.Point(31, 25);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(178, 55);
            this.btn_gen.TabIndex = 0;
            this.btn_gen.Text = "GENERATE";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.Btn_gen_Click);
            // 
            // txt_minuten
            // 
            this.txt_minuten.Location = new System.Drawing.Point(31, 113);
            this.txt_minuten.Name = "txt_minuten";
            this.txt_minuten.Size = new System.Drawing.Size(178, 20);
            this.txt_minuten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutes:";
            // 
            // lbl_licht_or_donker
            // 
            this.lbl_licht_or_donker.AutoSize = true;
            this.lbl_licht_or_donker.Location = new System.Drawing.Point(28, 147);
            this.lbl_licht_or_donker.Name = "lbl_licht_or_donker";
            this.lbl_licht_or_donker.Size = new System.Drawing.Size(94, 13);
            this.lbl_licht_or_donker.TabIndex = 3;
            this.lbl_licht_or_donker.Text = "<Licht Of Donker>";
            // 
            // afbeelding
            // 
            this.afbeelding.Image = ((System.Drawing.Image)(resources.GetObject("afbeelding.Image")));
            this.afbeelding.Location = new System.Drawing.Point(229, -6);
            this.afbeelding.Name = "afbeelding";
            this.afbeelding.Size = new System.Drawing.Size(382, 190);
            this.afbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.afbeelding.TabIndex = 4;
            this.afbeelding.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 180);
            this.Controls.Add(this.afbeelding);
            this.Controls.Add(this.lbl_licht_or_donker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_minuten);
            this.Controls.Add(this.btn_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Day\'Nite";
            ((System.ComponentModel.ISupportInitialize)(this.afbeelding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.TextBox txt_minuten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_licht_or_donker;
        private System.Windows.Forms.PictureBox afbeelding;
    }
}

