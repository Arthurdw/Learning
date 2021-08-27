namespace PROJECT_3_GETALCHECK
{
    partial class Ilusion
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
            this.cbSelected = new System.Windows.Forms.ComboBox();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbSelected
            // 
            this.cbSelected.FormattingEnabled = true;
            this.cbSelected.Items.AddRange(new object[] {
            "(Kies een kleur.)",
            "Lime",
            "Tomato",
            "Cornflowerblue",
            "Aquamarine",
            "Orange",
            "BlueViolet"});
            this.cbSelected.Location = new System.Drawing.Point(13, 13);
            this.cbSelected.Name = "cbSelected";
            this.cbSelected.Size = new System.Drawing.Size(587, 21);
            this.cbSelected.TabIndex = 0;
            this.cbSelected.SelectedIndexChanged += new System.EventHandler(this.CbSelected_SelectedIndexChanged);
            // 
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.SystemColors.Control;
            this.pnlShow.Location = new System.Drawing.Point(13, 40);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(587, 398);
            this.pnlShow.TabIndex = 1;
            // 
            // Ilusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.cbSelected);
            this.Name = "Ilusion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPTISHE ILLUSIE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelected;
        private System.Windows.Forms.Panel pnlShow;
    }
}

