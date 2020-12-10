namespace RadioRockNRoll
{
    partial class FrmInloggen
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernaam = new System.Windows.Forms.TextBox();
            this.txtPaswoord = new System.Windows.Forms.TextBox();
            this.btnNaarHetSpel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usernaam: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paswoord:";
            // 
            // txtUsernaam
            // 
            this.txtUsernaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernaam.Location = new System.Drawing.Point(131, 6);
            this.txtUsernaam.Name = "txtUsernaam";
            this.txtUsernaam.Size = new System.Drawing.Size(247, 30);
            this.txtUsernaam.TabIndex = 2;
            // 
            // txtPaswoord
            // 
            this.txtPaswoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaswoord.Location = new System.Drawing.Point(131, 42);
            this.txtPaswoord.Name = "txtPaswoord";
            this.txtPaswoord.Size = new System.Drawing.Size(247, 30);
            this.txtPaswoord.TabIndex = 3;
            // 
            // btnNaarHetSpel
            // 
            this.btnNaarHetSpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarHetSpel.Location = new System.Drawing.Point(17, 82);
            this.btnNaarHetSpel.Name = "btnNaarHetSpel";
            this.btnNaarHetSpel.Size = new System.Drawing.Size(361, 66);
            this.btnNaarHetSpel.TabIndex = 4;
            this.btnNaarHetSpel.Text = "Naar het spel";
            this.btnNaarHetSpel.UseVisualStyleBackColor = true;
            this.btnNaarHetSpel.Click += new System.EventHandler(this.btnNaarHetSpel_Click);
            // 
            // FrmInloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 166);
            this.Controls.Add(this.btnNaarHetSpel);
            this.Controls.Add(this.txtPaswoord);
            this.Controls.Add(this.txtUsernaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInloggen";
            this.Text = "LOG IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernaam;
        private System.Windows.Forms.TextBox txtPaswoord;
        private System.Windows.Forms.Button btnNaarHetSpel;
    }
}

