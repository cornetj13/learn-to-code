namespace CandyCrush {
    partial class Form1 {
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.aquaButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.fuchsiaButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.limeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(550, 426);
            this.mainPanel.TabIndex = 0;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(578, 12);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(97, 63);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(691, 12);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(97, 63);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(691, 81);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(97, 63);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // aquaButton
            // 
            this.aquaButton.BackColor = System.Drawing.Color.Aqua;
            this.aquaButton.Location = new System.Drawing.Point(691, 150);
            this.aquaButton.Name = "aquaButton";
            this.aquaButton.Size = new System.Drawing.Size(97, 63);
            this.aquaButton.TabIndex = 4;
            this.aquaButton.UseVisualStyleBackColor = false;
            this.aquaButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(578, 81);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(97, 63);
            this.greenButton.TabIndex = 5;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // fuchsiaButton
            // 
            this.fuchsiaButton.BackColor = System.Drawing.Color.Fuchsia;
            this.fuchsiaButton.Location = new System.Drawing.Point(691, 219);
            this.fuchsiaButton.Name = "fuchsiaButton";
            this.fuchsiaButton.Size = new System.Drawing.Size(97, 72);
            this.fuchsiaButton.TabIndex = 6;
            this.fuchsiaButton.UseVisualStyleBackColor = false;
            this.fuchsiaButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.Location = new System.Drawing.Point(578, 150);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(97, 63);
            this.orangeButton.TabIndex = 7;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // limeButton
            // 
            this.limeButton.BackColor = System.Drawing.Color.Lime;
            this.limeButton.Location = new System.Drawing.Point(578, 224);
            this.limeButton.Name = "limeButton";
            this.limeButton.Size = new System.Drawing.Size(97, 63);
            this.limeButton.TabIndex = 8;
            this.limeButton.UseVisualStyleBackColor = false;
            this.limeButton.Click += new System.EventHandler(this.colorbutton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(578, 377);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(210, 61);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(578, 294);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(210, 77);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.limeButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.fuchsiaButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.aquaButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button aquaButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button fuchsiaButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button limeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

