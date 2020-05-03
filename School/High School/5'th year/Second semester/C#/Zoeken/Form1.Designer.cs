namespace Zoeken
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zOEKENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opEersteIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoekManueelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoekenMetBeginletterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zOEKENToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zOEKENToolStripMenuItem
            // 
            this.zOEKENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opEersteIndexToolStripMenuItem,
            this.opToolStripMenuItem,
            this.findToolStripMenuItem,
            this.zoekManueelToolStripMenuItem,
            this.zoekenMetBeginletterToolStripMenuItem});
            this.zOEKENToolStripMenuItem.Name = "zOEKENToolStripMenuItem";
            this.zOEKENToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zOEKENToolStripMenuItem.Text = "ZOEKEN";
            // 
            // opEersteIndexToolStripMenuItem
            // 
            this.opEersteIndexToolStripMenuItem.Name = "opEersteIndexToolStripMenuItem";
            this.opEersteIndexToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.opEersteIndexToolStripMenuItem.Text = "op eerste index";
            this.opEersteIndexToolStripMenuItem.Click += new System.EventHandler(this.OpEersteIndexToolStripMenuItem_Click);
            // 
            // opToolStripMenuItem
            // 
            this.opToolStripMenuItem.Name = "opToolStripMenuItem";
            this.opToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.opToolStripMenuItem.Text = "op laatste index ";
            this.opToolStripMenuItem.Click += new System.EventHandler(this.OpToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // zoekManueelToolStripMenuItem
            // 
            this.zoekManueelToolStripMenuItem.Name = "zoekManueelToolStripMenuItem";
            this.zoekManueelToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zoekManueelToolStripMenuItem.Text = "Zoek manueel";
            this.zoekManueelToolStripMenuItem.Click += new System.EventHandler(this.ZoekManueelToolStripMenuItem_Click);
            // 
            // zoekenMetBeginletterToolStripMenuItem
            // 
            this.zoekenMetBeginletterToolStripMenuItem.Name = "zoekenMetBeginletterToolStripMenuItem";
            this.zoekenMetBeginletterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zoekenMetBeginletterToolStripMenuItem.Text = "Zoeken met beginletter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wie zoek je";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 83);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(219, 112);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 207);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zOEKENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opEersteIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoekManueelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoekenMetBeginletterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtResult;
    }
}

