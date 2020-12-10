namespace RadioRockNRoll
{
    partial class FrmAdmin
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
            this.bEHEERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deelnemersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importeerNieuweDeelnemersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importeerPrijzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgDeelnemers = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeelnemers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bEHEERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bEHEERToolStripMenuItem
            // 
            this.bEHEERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deelnemersToolStripMenuItem,
            this.importeerNieuweDeelnemersToolStripMenuItem,
            this.importeerPrijzenToolStripMenuItem});
            this.bEHEERToolStripMenuItem.Name = "bEHEERToolStripMenuItem";
            this.bEHEERToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.bEHEERToolStripMenuItem.Text = "BEHEER";
            // 
            // deelnemersToolStripMenuItem
            // 
            this.deelnemersToolStripMenuItem.Name = "deelnemersToolStripMenuItem";
            this.deelnemersToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.deelnemersToolStripMenuItem.Text = "Deelnemers";
            this.deelnemersToolStripMenuItem.Click += new System.EventHandler(this.deelnemersToolStripMenuItem_Click);
            // 
            // importeerNieuweDeelnemersToolStripMenuItem
            // 
            this.importeerNieuweDeelnemersToolStripMenuItem.Name = "importeerNieuweDeelnemersToolStripMenuItem";
            this.importeerNieuweDeelnemersToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.importeerNieuweDeelnemersToolStripMenuItem.Text = "Importeer nieuwe deelnemers";
            this.importeerNieuweDeelnemersToolStripMenuItem.Click += new System.EventHandler(this.importeerNieuweDeelnemersToolStripMenuItem_Click);
            // 
            // importeerPrijzenToolStripMenuItem
            // 
            this.importeerPrijzenToolStripMenuItem.Name = "importeerPrijzenToolStripMenuItem";
            this.importeerPrijzenToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.importeerPrijzenToolStripMenuItem.Text = "Importeer prijzen";
            this.importeerPrijzenToolStripMenuItem.Click += new System.EventHandler(this.importeerPrijzenToolStripMenuItem_Click);
            // 
            // dgDeelnemers
            // 
            this.dgDeelnemers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDeelnemers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeelnemers.Location = new System.Drawing.Point(13, 32);
            this.dgDeelnemers.Name = "dgDeelnemers";
            this.dgDeelnemers.RowHeadersWidth = 51;
            this.dgDeelnemers.RowTemplate.Height = 24;
            this.dgDeelnemers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDeelnemers.Size = new System.Drawing.Size(775, 406);
            this.dgDeelnemers.TabIndex = 1;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgDeelnemers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.Text = "BEHEER KERSTSPEL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeelnemers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bEHEERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deelnemersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importeerNieuweDeelnemersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importeerPrijzenToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgDeelnemers;
    }
}