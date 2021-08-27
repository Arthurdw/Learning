namespace Lottery
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
            this.ptb_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_bonus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_image
            // 
            this.ptb_image.Image = ((System.Drawing.Image)(resources.GetObject("ptb_image.Image")));
            this.ptb_image.Location = new System.Drawing.Point(193, 12);
            this.ptb_image.Name = "ptb_image";
            this.ptb_image.Size = new System.Drawing.Size(497, 370);
            this.ptb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_image.TabIndex = 1;
            this.ptb_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leeftijd 2020:";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_age.Location = new System.Drawing.Point(12, 123);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(81, 31);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "0 jaar";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_submit.Location = new System.Drawing.Point(12, 260);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(175, 64);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(12, 53);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(175, 20);
            this.dtp_birthday.TabIndex = 5;
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.AutoSize = true;
            this.lbl_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_bonus.Location = new System.Drawing.Point(12, 202);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(90, 31);
            this.lbl_bonus.TabIndex = 7;
            this.lbl_bonus.Text = "0 euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bonus:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(708, 394);
            this.Controls.Add(this.lbl_bonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label lbl_bonus;
        private System.Windows.Forms.Label label3;
    }
}

