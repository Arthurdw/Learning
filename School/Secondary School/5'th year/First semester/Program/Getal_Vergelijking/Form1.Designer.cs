namespace Getal_Vergelijking
{
    partial class window
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
            this.txtnumb = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_bigger = new System.Windows.Forms.Label();
            this.lbl_difference = new System.Windows.Forms.Label();
            this.lbl_even = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnumb
            // 
            this.txtnumb.Location = new System.Drawing.Point(12, 12);
            this.txtnumb.Name = "txtnumb";
            this.txtnumb.Size = new System.Drawing.Size(100, 20);
            this.txtnumb.TabIndex = 0;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(12, 39);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(100, 42);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.Btn_check_Click);
            // 
            // lbl_bigger
            // 
            this.lbl_bigger.AutoSize = true;
            this.lbl_bigger.Location = new System.Drawing.Point(147, 12);
            this.lbl_bigger.Name = "lbl_bigger";
            this.lbl_bigger.Size = new System.Drawing.Size(107, 13);
            this.lbl_bigger.TabIndex = 4;
            this.lbl_bigger.Text = "(numb1) >=< (numb2)";
            // 
            // lbl_difference
            // 
            this.lbl_difference.AutoSize = true;
            this.lbl_difference.Location = new System.Drawing.Point(147, 39);
            this.lbl_difference.Name = "lbl_difference";
            this.lbl_difference.Size = new System.Drawing.Size(92, 13);
            this.lbl_difference.TabIndex = 5;
            this.lbl_difference.Text = "Verschil: (verschil)";
            // 
            // lbl_even
            // 
            this.lbl_even.AutoSize = true;
            this.lbl_even.Location = new System.Drawing.Point(147, 68);
            this.lbl_even.Name = "lbl_even";
            this.lbl_even.Size = new System.Drawing.Size(80, 13);
            this.lbl_even.TabIndex = 6;
            this.lbl_even.Text = "Even: (Ja/Nee)";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 94);
            this.Controls.Add(this.lbl_even);
            this.Controls.Add(this.lbl_difference);
            this.Controls.Add(this.lbl_bigger);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txtnumb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "window";
            this.Text = "Getal Vergelijking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumb;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lbl_bigger;
        private System.Windows.Forms.Label lbl_difference;
        private System.Windows.Forms.Label lbl_even;
    }
}

