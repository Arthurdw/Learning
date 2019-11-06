namespace calc
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
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.txtplusbutton = new System.Windows.Forms.Button();
            this.txtminbutton = new System.Windows.Forms.Button();
            this.txtmultibutton = new System.Windows.Forms.Button();
            this.txtpartbutton = new System.Windows.Forms.Button();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlastoutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalcModulo = new System.Windows.Forms.Button();
            this.txtModuloOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(12, 12);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(146, 20);
            this.txtinput1.TabIndex = 0;
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(12, 38);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(146, 20);
            this.txtinput2.TabIndex = 1;
            // 
            // txtplusbutton
            // 
            this.txtplusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplusbutton.Location = new System.Drawing.Point(12, 64);
            this.txtplusbutton.Name = "txtplusbutton";
            this.txtplusbutton.Size = new System.Drawing.Size(70, 66);
            this.txtplusbutton.TabIndex = 2;
            this.txtplusbutton.Text = "+";
            this.txtplusbutton.UseVisualStyleBackColor = true;
            this.txtplusbutton.Click += new System.EventHandler(this.Plusbutton_Click);
            // 
            // txtminbutton
            // 
            this.txtminbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminbutton.Location = new System.Drawing.Point(88, 64);
            this.txtminbutton.Name = "txtminbutton";
            this.txtminbutton.Size = new System.Drawing.Size(70, 66);
            this.txtminbutton.TabIndex = 3;
            this.txtminbutton.Text = "-";
            this.txtminbutton.UseVisualStyleBackColor = true;
            this.txtminbutton.Click += new System.EventHandler(this.Txtminbutton_Click);
            // 
            // txtmultibutton
            // 
            this.txtmultibutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmultibutton.Location = new System.Drawing.Point(12, 136);
            this.txtmultibutton.Name = "txtmultibutton";
            this.txtmultibutton.Size = new System.Drawing.Size(70, 66);
            this.txtmultibutton.TabIndex = 4;
            this.txtmultibutton.Text = "x";
            this.txtmultibutton.UseVisualStyleBackColor = true;
            this.txtmultibutton.Click += new System.EventHandler(this.Txtmultibutton_Click);
            // 
            // txtpartbutton
            // 
            this.txtpartbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartbutton.Location = new System.Drawing.Point(88, 136);
            this.txtpartbutton.Name = "txtpartbutton";
            this.txtpartbutton.Size = new System.Drawing.Size(70, 66);
            this.txtpartbutton.TabIndex = 5;
            this.txtpartbutton.Text = "/";
            this.txtpartbutton.UseVisualStyleBackColor = true;
            this.txtpartbutton.Click += new System.EventHandler(this.Txtpartbutton_Click);
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(12, 237);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(146, 20);
            this.txtoutput.TabIndex = 6;
            this.txtoutput.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Out:";
            // 
            // txtlastoutput
            // 
            this.txtlastoutput.Location = new System.Drawing.Point(12, 292);
            this.txtlastoutput.Name = "txtlastoutput";
            this.txtlastoutput.Size = new System.Drawing.Size(146, 20);
            this.txtlastoutput.TabIndex = 8;
            this.txtlastoutput.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last:";
            // 
            // txtCalcModulo
            // 
            this.txtCalcModulo.Location = new System.Drawing.Point(13, 328);
            this.txtCalcModulo.Name = "txtCalcModulo";
            this.txtCalcModulo.Size = new System.Drawing.Size(145, 23);
            this.txtCalcModulo.TabIndex = 10;
            this.txtCalcModulo.Text = "Calc Modulo";
            this.txtCalcModulo.UseVisualStyleBackColor = true;
            this.txtCalcModulo.Click += new System.EventHandler(this.TxtCalcModulo_Click);
            // 
            // txtModuloOut
            // 
            this.txtModuloOut.Location = new System.Drawing.Point(13, 357);
            this.txtModuloOut.Name = "txtModuloOut";
            this.txtModuloOut.Size = new System.Drawing.Size(146, 20);
            this.txtModuloOut.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(165, 387);
            this.Controls.Add(this.txtModuloOut);
            this.Controls.Add(this.txtCalcModulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlastoutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtpartbutton);
            this.Controls.Add(this.txtmultibutton);
            this.Controls.Add(this.txtminbutton);
            this.Controls.Add(this.txtplusbutton);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.Button txtplusbutton;
        private System.Windows.Forms.Button txtminbutton;
        private System.Windows.Forms.Button txtmultibutton;
        private System.Windows.Forms.Button txtpartbutton;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlastoutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtCalcModulo;
        private System.Windows.Forms.TextBox txtModuloOut;
    }
}

