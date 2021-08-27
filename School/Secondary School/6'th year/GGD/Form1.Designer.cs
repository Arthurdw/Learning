namespace GGD
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
            this.ButtonGretig = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.ButtonEfficient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Output1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal1:";
            // 
            // ButtonGretig
            // 
            this.ButtonGretig.Location = new System.Drawing.Point(16, 62);
            this.ButtonGretig.Name = "ButtonGretig";
            this.ButtonGretig.Size = new System.Drawing.Size(170, 83);
            this.ButtonGretig.TabIndex = 3;
            this.ButtonGretig.Text = "Gretig";
            this.ButtonGretig.UseVisualStyleBackColor = true;
            this.ButtonGretig.Click += new System.EventHandler(this.ButtonGretig_Click);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(64, 18);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(121, 22);
            this.Input1.TabIndex = 1;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(254, 18);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(121, 22);
            this.Input2.TabIndex = 2;
            // 
            // ButtonEfficient
            // 
            this.ButtonEfficient.Location = new System.Drawing.Point(206, 62);
            this.ButtonEfficient.Name = "ButtonEfficient";
            this.ButtonEfficient.Size = new System.Drawing.Size(170, 83);
            this.ButtonEfficient.TabIndex = 4;
            this.ButtonEfficient.Text = "Efficient";
            this.ButtonEfficient.UseVisualStyleBackColor = true;
            this.ButtonEfficient.Click += new System.EventHandler(this.ButtonEfficient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Getal2:";
            // 
            // Output1
            // 
            this.Output1.Location = new System.Drawing.Point(15, 162);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(359, 22);
            this.Output1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 196);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.ButtonEfficient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.ButtonGretig);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GGD Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonGretig;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Button ButtonEfficient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output1;
    }
}

