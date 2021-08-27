namespace TrafficLights
{
    partial class TrafficLightsSimulator
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
            this.PanelLight = new System.Windows.Forms.Panel();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TextCountBox = new System.Windows.Forms.TextBox();
            this.ButtonFrench = new System.Windows.Forms.Button();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelLight
            // 
            this.PanelLight.BackColor = System.Drawing.Color.Black;
            this.PanelLight.Location = new System.Drawing.Point(13, 156);
            this.PanelLight.Name = "PanelLight";
            this.PanelLight.Size = new System.Drawing.Size(150, 400);
            this.PanelLight.TabIndex = 0;
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.White;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonStart.Location = new System.Drawing.Point(13, 39);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(150, 33);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start Lights";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TextCountBox
            // 
            this.TextCountBox.Enabled = false;
            this.TextCountBox.Location = new System.Drawing.Point(13, 13);
            this.TextCountBox.Name = "TextCountBox";
            this.TextCountBox.Size = new System.Drawing.Size(150, 20);
            this.TextCountBox.TabIndex = 2;
            // 
            // ButtonFrench
            // 
            this.ButtonFrench.BackColor = System.Drawing.Color.White;
            this.ButtonFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonFrench.Location = new System.Drawing.Point(13, 117);
            this.ButtonFrench.Name = "ButtonFrench";
            this.ButtonFrench.Size = new System.Drawing.Size(150, 33);
            this.ButtonFrench.TabIndex = 3;
            this.ButtonFrench.Text = "French Lights";
            this.ButtonFrench.UseVisualStyleBackColor = false;
            this.ButtonFrench.Click += new System.EventHandler(this.ButtonFrench_Click);
            // 
            // ButtonTest
            // 
            this.ButtonTest.BackColor = System.Drawing.Color.White;
            this.ButtonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonTest.Location = new System.Drawing.Point(15, 78);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(150, 33);
            this.ButtonTest.TabIndex = 4;
            this.ButtonTest.Text = "Test Lights";
            this.ButtonTest.UseVisualStyleBackColor = false;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TrafficLightsSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(177, 568);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.ButtonFrench);
            this.Controls.Add(this.TextCountBox);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.PanelLight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrafficLightsSimulator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLight;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox TextCountBox;
        private System.Windows.Forms.Button ButtonFrench;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Timer Timer;
    }
}

