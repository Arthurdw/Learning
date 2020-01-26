namespace Discord_Bots_Stats
{
    partial class DBS
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
            this.lblBots = new System.Windows.Forms.Label();
            this.txtServers = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.lblCommands = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBots
            // 
            this.lblBots.AutoSize = true;
            this.lblBots.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblBots.Location = new System.Drawing.Point(12, 9);
            this.lblBots.Name = "lblBots";
            this.lblBots.Size = new System.Drawing.Size(242, 31);
            this.lblBots.TabIndex = 0;
            this.lblBots.Text = "Amount of servers:";
            // 
            // txtServers
            // 
            this.txtServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtServers.Location = new System.Drawing.Point(265, 6);
            this.txtServers.Name = "txtServers";
            this.txtServers.Size = new System.Drawing.Size(190, 37);
            this.txtServers.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtData.Location = new System.Drawing.Point(18, 96);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(617, 342);
            this.txtData.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnCalc.Location = new System.Drawing.Point(461, 6);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(174, 84);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCommands
            // 
            this.txtCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtCommands.Location = new System.Drawing.Point(316, 53);
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(139, 37);
            this.txtCommands.TabIndex = 5;
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblCommands.Location = new System.Drawing.Point(12, 56);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(284, 31);
            this.lblCommands.TabIndex = 4;
            this.lblCommands.Text = "Amount of commands:";
            // 
            // DBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.lblCommands);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtServers);
            this.Controls.Add(this.lblBots);
            this.Name = "DBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Bot Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBots;
        private System.Windows.Forms.TextBox txtServers;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Label lblCommands;
    }
}

