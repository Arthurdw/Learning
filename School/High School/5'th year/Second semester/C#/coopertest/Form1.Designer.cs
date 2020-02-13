namespace coopertest
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
            this.lblDeelNemer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAfstand = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDeelNemer
            // 
            this.lblDeelNemer.AutoSize = true;
            this.lblDeelNemer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDeelNemer.Location = new System.Drawing.Point(12, 9);
            this.lblDeelNemer.Name = "lblDeelNemer";
            this.lblDeelNemer.Size = new System.Drawing.Size(83, 13);
            this.lblDeelNemer.TabIndex = 0;
            this.lblDeelNemer.Text = "<DeelNemer>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Afstand op 12 mins. (m)";
            // 
            // txtAfstand
            // 
            this.txtAfstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAfstand.Location = new System.Drawing.Point(206, 19);
            this.txtAfstand.Name = "txtAfstand";
            this.txtAfstand.Size = new System.Drawing.Size(100, 26);
            this.txtAfstand.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnNext.Location = new System.Drawing.Point(312, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 27);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnReset.Location = new System.Drawing.Point(397, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 52);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(460, 386);
            this.txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAfstand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeelNemer);
            this.Name = "Form1";
            this.Text = "COOPERTEST 8 DEELNEMERS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeelNemer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAfstand;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtResult;
    }
}

