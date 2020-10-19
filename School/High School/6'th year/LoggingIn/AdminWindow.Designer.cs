namespace LoggingIn
{
    partial class AdminWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.lblPassReset = new System.Windows.Forms.Label();
            this.txtPassReset = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolsToolStripMenuItem
            // 
            this.adminToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.showAccountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.adminToolsToolStripMenuItem.Name = "adminToolsToolStripMenuItem";
            this.adminToolsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.adminToolsToolStripMenuItem.Text = "Admin Tools";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset Passwords";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // showAccountsToolStripMenuItem
            // 
            this.showAccountsToolStripMenuItem.Name = "showAccountsToolStripMenuItem";
            this.showAccountsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showAccountsToolStripMenuItem.Text = "Show Accounts";
            this.showAccountsToolStripMenuItem.Click += new System.EventHandler(this.showAccountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(12, 55);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(741, 406);
            this.dgData.TabIndex = 1;
            // 
            // lblPassReset
            // 
            this.lblPassReset.AutoSize = true;
            this.lblPassReset.Location = new System.Drawing.Point(12, 32);
            this.lblPassReset.Name = "lblPassReset";
            this.lblPassReset.Size = new System.Drawing.Size(267, 17);
            this.lblPassReset.TabIndex = 2;
            this.lblPassReset.Text = "(Nieuw watchtwoord voor alle gebruikers)";
            // 
            // txtPassReset
            // 
            this.txtPassReset.ForeColor = System.Drawing.Color.Red;
            this.txtPassReset.Location = new System.Drawing.Point(285, 29);
            this.txtPassReset.Name = "txtPassReset";
            this.txtPassReset.Size = new System.Drawing.Size(468, 22);
            this.txtPassReset.TabIndex = 3;
            this.txtPassReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPasswords);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 473);
            this.Controls.Add(this.txtPassReset);
            this.Controls.Add(this.lblPassReset);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminWindow";
            this.Text = "User Beheer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label lblPassReset;
        private System.Windows.Forms.TextBox txtPassReset;
    }
}