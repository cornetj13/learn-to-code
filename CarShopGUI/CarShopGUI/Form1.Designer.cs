﻿namespace CarShopGUI {
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
            this.createCarGroupBox = new System.Windows.Forms.GroupBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.isNewLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.isNewTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.createCarButton = new System.Windows.Forms.Button();
            this.carInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.carInventoryListBox = new System.Windows.Forms.ListBox();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.shoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalListBox = new System.Windows.Forms.ListBox();
            this.createCarGroupBox.SuspendLayout();
            this.carInventoryGroupBox.SuspendLayout();
            this.shoppingCartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCarGroupBox
            // 
            this.createCarGroupBox.Controls.Add(this.createCarButton);
            this.createCarGroupBox.Controls.Add(this.priceTextBox);
            this.createCarGroupBox.Controls.Add(this.isNewTextBox);
            this.createCarGroupBox.Controls.Add(this.colorTextBox);
            this.createCarGroupBox.Controls.Add(this.modelTextBox);
            this.createCarGroupBox.Controls.Add(this.makeTextBox);
            this.createCarGroupBox.Controls.Add(this.priceLabel);
            this.createCarGroupBox.Controls.Add(this.isNewLabel);
            this.createCarGroupBox.Controls.Add(this.colorLabel);
            this.createCarGroupBox.Controls.Add(this.modelLabel);
            this.createCarGroupBox.Controls.Add(this.makeLabel);
            this.createCarGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createCarGroupBox.Name = "createCarGroupBox";
            this.createCarGroupBox.Size = new System.Drawing.Size(202, 381);
            this.createCarGroupBox.TabIndex = 0;
            this.createCarGroupBox.TabStop = false;
            this.createCarGroupBox.Text = "Create a Car:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(7, 34);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(37, 13);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(7, 86);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(7, 138);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 4;
            this.colorLabel.Text = "Color:";
            // 
            // isNewLabel
            // 
            this.isNewLabel.AutoSize = true;
            this.isNewLabel.Location = new System.Drawing.Point(7, 190);
            this.isNewLabel.Name = "isNewLabel";
            this.isNewLabel.Size = new System.Drawing.Size(72, 13);
            this.isNewLabel.TabIndex = 6;
            this.isNewLabel.Text = "New or Used:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 242);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(99, 31);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(86, 20);
            this.makeTextBox.TabIndex = 9;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(99, 83);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(86, 20);
            this.modelTextBox.TabIndex = 11;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(99, 135);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(86, 20);
            this.colorTextBox.TabIndex = 13;
            // 
            // isNewTextBox
            // 
            this.isNewTextBox.Location = new System.Drawing.Point(99, 187);
            this.isNewTextBox.Name = "isNewTextBox";
            this.isNewTextBox.Size = new System.Drawing.Size(86, 20);
            this.isNewTextBox.TabIndex = 14;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(99, 239);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(86, 20);
            this.priceTextBox.TabIndex = 16;
            // 
            // createCarButton
            // 
            this.createCarButton.Location = new System.Drawing.Point(66, 319);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(75, 23);
            this.createCarButton.TabIndex = 17;
            this.createCarButton.Text = "Create Car";
            this.createCarButton.UseVisualStyleBackColor = true;
            // 
            // carInventoryGroupBox
            // 
            this.carInventoryGroupBox.Controls.Add(this.carInventoryListBox);
            this.carInventoryGroupBox.Location = new System.Drawing.Point(235, 12);
            this.carInventoryGroupBox.Name = "carInventoryGroupBox";
            this.carInventoryGroupBox.Size = new System.Drawing.Size(200, 381);
            this.carInventoryGroupBox.TabIndex = 1;
            this.carInventoryGroupBox.TabStop = false;
            this.carInventoryGroupBox.Text = "Car Inventory:";
            // 
            // carInventoryListBox
            // 
            this.carInventoryListBox.FormattingEnabled = true;
            this.carInventoryListBox.Items.AddRange(new object[] {
            ""});
            this.carInventoryListBox.Location = new System.Drawing.Point(6, 20);
            this.carInventoryListBox.Name = "carInventoryListBox";
            this.carInventoryListBox.Size = new System.Drawing.Size(188, 355);
            this.carInventoryListBox.TabIndex = 0;
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.Items.AddRange(new object[] {
            ""});
            this.shoppingCartListBox.Location = new System.Drawing.Point(6, 20);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(188, 316);
            this.shoppingCartListBox.TabIndex = 1;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(456, 192);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(105, 23);
            this.addToCartButton.TabIndex = 18;
            this.addToCartButton.Text = "Add to Cart -->";
            this.addToCartButton.UseVisualStyleBackColor = true;
            // 
            // shoppingCartGroupBox
            // 
            this.shoppingCartGroupBox.Controls.Add(this.totalListBox);
            this.shoppingCartGroupBox.Controls.Add(this.totalLabel);
            this.shoppingCartGroupBox.Controls.Add(this.totalPriceButton);
            this.shoppingCartGroupBox.Controls.Add(this.shoppingCartListBox);
            this.shoppingCartGroupBox.Location = new System.Drawing.Point(579, 12);
            this.shoppingCartGroupBox.Name = "shoppingCartGroupBox";
            this.shoppingCartGroupBox.Size = new System.Drawing.Size(200, 426);
            this.shoppingCartGroupBox.TabIndex = 19;
            this.shoppingCartGroupBox.TabStop = false;
            this.shoppingCartGroupBox.Text = "Shopping Cart:";
            // 
            // totalPriceButton
            // 
            this.totalPriceButton.Location = new System.Drawing.Point(65, 342);
            this.totalPriceButton.Name = "totalPriceButton";
            this.totalPriceButton.Size = new System.Drawing.Size(75, 23);
            this.totalPriceButton.TabIndex = 20;
            this.totalPriceButton.Text = "Checkout";
            this.totalPriceButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(22, 383);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 13);
            this.totalLabel.TabIndex = 21;
            this.totalLabel.Text = "Total Cost:";
            // 
            // totalListBox
            // 
            this.totalListBox.FormattingEnabled = true;
            this.totalListBox.Items.AddRange(new object[] {
            "$0.00"});
            this.totalListBox.Location = new System.Drawing.Point(111, 383);
            this.totalListBox.Name = "totalListBox";
            this.totalListBox.Size = new System.Drawing.Size(68, 17);
            this.totalListBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shoppingCartGroupBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.carInventoryGroupBox);
            this.Controls.Add(this.createCarGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.createCarGroupBox.ResumeLayout(false);
            this.createCarGroupBox.PerformLayout();
            this.carInventoryGroupBox.ResumeLayout(false);
            this.shoppingCartGroupBox.ResumeLayout(false);
            this.shoppingCartGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createCarGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox isNewTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label isNewLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.GroupBox carInventoryGroupBox;
        private System.Windows.Forms.ListBox carInventoryListBox;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.GroupBox shoppingCartGroupBox;
        private System.Windows.Forms.ListBox totalListBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button totalPriceButton;
    }
}

