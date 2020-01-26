namespace EnumDays
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
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtDayNumb = new System.Windows.Forms.TextBox();
            this.dtpSelected = new System.Windows.Forms.DateTimePicker();
            this.btnDayNumb = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnDayAndNumb = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(10, 11);
            this.txtDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(165, 20);
            this.txtDay.TabIndex = 0;
            // 
            // txtDayNumb
            // 
            this.txtDayNumb.Location = new System.Drawing.Point(10, 33);
            this.txtDayNumb.Margin = new System.Windows.Forms.Padding(2);
            this.txtDayNumb.Name = "txtDayNumb";
            this.txtDayNumb.Size = new System.Drawing.Size(165, 20);
            this.txtDayNumb.TabIndex = 1;
            // 
            // dtpSelected
            // 
            this.dtpSelected.Location = new System.Drawing.Point(10, 57);
            this.dtpSelected.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSelected.Name = "dtpSelected";
            this.dtpSelected.Size = new System.Drawing.Size(165, 20);
            this.dtpSelected.TabIndex = 2;
            // 
            // btnDayNumb
            // 
            this.btnDayNumb.Location = new System.Drawing.Point(10, 84);
            this.btnDayNumb.Margin = new System.Windows.Forms.Padding(2);
            this.btnDayNumb.Name = "btnDayNumb";
            this.btnDayNumb.Size = new System.Drawing.Size(164, 24);
            this.btnDayNumb.TabIndex = 3;
            this.btnDayNumb.Text = "Wat is de waarde?";
            this.btnDayNumb.UseVisualStyleBackColor = true;
            this.btnDayNumb.Click += new System.EventHandler(this.btnDayNumb_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(10, 113);
            this.btnDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(164, 24);
            this.btnDay.TabIndex = 4;
            this.btnDay.Text = "Wat is de dag?";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnDayAndNumb
            // 
            this.btnDayAndNumb.Location = new System.Drawing.Point(10, 142);
            this.btnDayAndNumb.Margin = new System.Windows.Forms.Padding(2);
            this.btnDayAndNumb.Name = "btnDayAndNumb";
            this.btnDayAndNumb.Size = new System.Drawing.Size(164, 24);
            this.btnDayAndNumb.TabIndex = 5;
            this.btnDayAndNumb.Text = "Dag en waarde?";
            this.btnDayAndNumb.UseVisualStyleBackColor = true;
            this.btnDayAndNumb.Click += new System.EventHandler(this.btnDayAndNumb_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(179, 11);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(314, 158);
            this.txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 177);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDayAndNumb);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnDayNumb);
            this.Controls.Add(this.dtpSelected);
            this.Controls.Add(this.txtDayNumb);
            this.Controls.Add(this.txtDay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtDayNumb;
        private System.Windows.Forms.DateTimePicker dtpSelected;
        private System.Windows.Forms.Button btnDayNumb;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnDayAndNumb;
        private System.Windows.Forms.TextBox txtResult;
    }
}

