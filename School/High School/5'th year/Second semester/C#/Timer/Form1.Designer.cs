namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTijdNu = new System.Windows.Forms.Label();
            this.lblTijdTeller = new System.Windows.Forms.Label();
            this.tmrGeneral = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start de timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(174, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(155, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop de timer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTijdNu
            // 
            this.lblTijdNu.AutoSize = true;
            this.lblTijdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTijdNu.Location = new System.Drawing.Point(13, 53);
            this.lblTijdNu.Name = "lblTijdNu";
            this.lblTijdNu.Size = new System.Drawing.Size(64, 25);
            this.lblTijdNu.TabIndex = 2;
            this.lblTijdNu.Text = "<tijd>";
            // 
            // lblTijdTeller
            // 
            this.lblTijdTeller.AutoSize = true;
            this.lblTijdTeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblTijdTeller.Location = new System.Drawing.Point(13, 90);
            this.lblTijdTeller.Name = "lblTijdTeller";
            this.lblTijdTeller.Size = new System.Drawing.Size(76, 29);
            this.lblTijdTeller.TabIndex = 3;
            this.lblTijdTeller.Text = "<tijd>";
            // 
            // tmrGeneral
            // 
            this.tmrGeneral.Interval = 10;
            this.tmrGeneral.Tick += new System.EventHandler(this.tmrGeneral_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 136);
            this.Controls.Add(this.lblTijdTeller);
            this.Controls.Add(this.lblTijdNu);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTijdNu;
        private System.Windows.Forms.Label lblTijdTeller;
        private System.Windows.Forms.Timer tmrGeneral;
    }
}

