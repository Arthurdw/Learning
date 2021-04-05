
namespace Collatz2._0
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
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.bar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 309);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(499, 222);
            this.txtOut.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 269);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(240, 34);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(12, 13);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(500, 250);
            this.pnl.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(270, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(240, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // drawTimer
            // 
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(13, 538);
            this.bar.Maximum = 500;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(497, 45);
            this.bar.TabIndex = 10;
            this.bar.Value = 100;
            this.bar.Scroll += new System.EventHandler(this.bar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 582);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.Text = "Collatz 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.TrackBar bar;
    }
}

