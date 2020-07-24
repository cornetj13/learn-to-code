namespace ChessBoardGUIApp {
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectedPieceComboBox = new System.Windows.Forms.ComboBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a piece from the drop down menu and pick a square to see legal moves:";
            // 
            // selectedPieceComboBox
            // 
            this.selectedPieceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedPieceComboBox.FormattingEnabled = true;
            this.selectedPieceComboBox.Items.AddRange(new object[] {
            "Bishop",
            "King",
            "Knight",
            "Queen",
            "Rook"});
            this.selectedPieceComboBox.Location = new System.Drawing.Point(393, 10);
            this.selectedPieceComboBox.Name = "selectedPieceComboBox";
            this.selectedPieceComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectedPieceComboBox.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(12, 40);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(500, 500);
            this.buttonPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 552);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.selectedPieceComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chess Piece Moves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectedPieceComboBox;
        private System.Windows.Forms.Panel buttonPanel;
    }
}

