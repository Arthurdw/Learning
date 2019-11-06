namespace Black_Or_Red {
    partial class Black_Red {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startbedrag = new System.Windows.Forms.Label();
            this.inzet = new System.Windows.Forms.Label();
            this.gok = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            this.txt_StartAmount = new System.Windows.Forms.TextBox();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbedrag
            // 
            this.startbedrag.AutoSize = true;
            this.startbedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.startbedrag.ForeColor = System.Drawing.Color.White;
            this.startbedrag.Location = new System.Drawing.Point(21, 20);
            this.startbedrag.Name = "startbedrag";
            this.startbedrag.Size = new System.Drawing.Size(136, 25);
            this.startbedrag.TabIndex = 0;
            this.startbedrag.Text = "Start bedrag:";
            // 
            // inzet
            // 
            this.inzet.AutoSize = true;
            this.inzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.inzet.ForeColor = System.Drawing.Color.White;
            this.inzet.Location = new System.Drawing.Point(21, 43);
            this.inzet.Name = "inzet";
            this.inzet.Size = new System.Drawing.Size(64, 25);
            this.inzet.TabIndex = 1;
            this.inzet.Text = "Inzet:";
            // 
            // gok
            // 
            this.gok.AutoSize = true;
            this.gok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.gok.ForeColor = System.Drawing.Color.White;
            this.gok.Location = new System.Drawing.Point(21, 90);
            this.gok.Name = "gok";
            this.gok.Size = new System.Drawing.Size(75, 25);
            this.gok.TabIndex = 2;
            this.gok.Text = "Ik gok:";
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_NewGame.Location = new System.Drawing.Point(289, 20);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(134, 69);
            this.btn_NewGame.TabIndex = 3;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.Btn_NewGame_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_Red.ForeColor = System.Drawing.Color.Black;
            this.btn_Red.Location = new System.Drawing.Point(26, 126);
            this.btn_Red.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(190, 40);
            this.btn_Red.TabIndex = 4;
            this.btn_Red.Text = "ROOD";
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.Btn_rood_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_Black.ForeColor = System.Drawing.Color.White;
            this.btn_Black.Location = new System.Drawing.Point(233, 126);
            this.btn_Black.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(190, 40);
            this.btn_Black.TabIndex = 5;
            this.btn_Black.Text = "ZWART";
            this.btn_Black.UseVisualStyleBackColor = false;
            this.btn_Black.Click += new System.EventHandler(this.Btn_Black_Click);
            // 
            // txt_StartAmount
            // 
            this.txt_StartAmount.Location = new System.Drawing.Point(164, 26);
            this.txt_StartAmount.Name = "txt_StartAmount";
            this.txt_StartAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_StartAmount.TabIndex = 6;
            this.txt_StartAmount.Text = "0";
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(164, 49);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(100, 20);
            this.txt_Input.TabIndex = 7;
            this.txt_Input.Text = "---------------------------------------------------------------";
            // 
            // btn_Result
            // 
            this.btn_Result.BackColor = System.Drawing.Color.Gray;
            this.btn_Result.Location = new System.Drawing.Point(26, 192);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(397, 184);
            this.btn_Result.TabIndex = 8;
            this.btn_Result.UseVisualStyleBackColor = false;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_Amount.ForeColor = System.Drawing.Color.Red;
            this.lbl_Amount.Location = new System.Drawing.Point(24, 413);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(360, 39);
            this.lbl_Amount.TabIndex = 9;
            this.lbl_Amount.Text = "     <resterend bedrag>";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_error.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_error.Location = new System.Drawing.Point(24, 379);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 39);
            this.lbl_error.TabIndex = 10;
            // 
            // Black_Red
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(446, 458);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.txt_StartAmount);
            this.Controls.Add(this.btn_Black);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.gok);
            this.Controls.Add(this.inzet);
            this.Controls.Add(this.startbedrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Black_Red";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Or Red";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label startbedrag;
        private System.Windows.Forms.Label inzet;
        private System.Windows.Forms.Label gok;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Black;
        private System.Windows.Forms.TextBox txt_StartAmount;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_error;
    }
}

