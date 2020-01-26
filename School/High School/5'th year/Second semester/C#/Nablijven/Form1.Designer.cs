namespace Nablijven
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
            this.lblDag = new System.Windows.Forms.Label();
            this.txtUur = new System.Windows.Forms.TextBox();
            this.txtMinuut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDag
            // 
            this.lblDag.AutoSize = true;
            this.lblDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblDag.Location = new System.Drawing.Point(13, 13);
            this.lblDag.Name = "lblDag";
            this.lblDag.Size = new System.Drawing.Size(75, 25);
            this.lblDag.TabIndex = 0;
            this.lblDag.Text = "Dag 1:";
            // 
            // txtUur
            // 
            this.txtUur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtUur.Location = new System.Drawing.Point(13, 42);
            this.txtUur.Name = "txtUur";
            this.txtUur.Size = new System.Drawing.Size(100, 31);
            this.txtUur.TabIndex = 1;
            // 
            // txtMinuut
            // 
            this.txtMinuut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtMinuut.Location = new System.Drawing.Point(140, 42);
            this.txtMinuut.Name = "txtMinuut";
            this.txtMinuut.Size = new System.Drawing.Size(100, 31);
            this.txtMinuut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(119, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(260, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "INCHECKEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Location = new System.Drawing.Point(411, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nieuwe invoer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblOut.Location = new System.Drawing.Point(13, 93);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 25);
            this.lblOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 125);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinuut);
            this.Controls.Add(this.txtUur);
            this.Controls.Add(this.lblDag);
            this.Name = "Form1";
            this.Text = "Snel Inchecken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDag;
        private System.Windows.Forms.TextBox txtUur;
        private System.Windows.Forms.TextBox txtMinuut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOut;
    }
}

