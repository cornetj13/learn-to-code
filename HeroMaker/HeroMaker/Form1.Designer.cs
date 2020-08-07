namespace HeroMaker {
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_flight = new System.Windows.Forms.CheckBox();
            this.chk_strength = new System.Windows.Forms.CheckBox();
            this.chk_invisible = new System.Windows.Forms.CheckBox();
            this.chk_healing = new System.Windows.Forms.CheckBox();
            this.chk_agility = new System.Windows.Forms.CheckBox();
            this.chk_invulnerable = new System.Windows.Forms.CheckBox();
            this.chk_intelligence = new System.Windows.Forms.CheckBox();
            this.chk_animalcommunication = new System.Windows.Forms.CheckBox();
            this.chk_teleportation = new System.Windows.Forms.CheckBox();
            this.chk_claws = new System.Windows.Forms.CheckBox();
            this.chk_telepathy = new System.Windows.Forms.CheckBox();
            this.chk_weapons = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero\'s Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(89, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(131, 20);
            this.txt_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_weapons);
            this.groupBox1.Controls.Add(this.chk_telepathy);
            this.groupBox1.Controls.Add(this.chk_claws);
            this.groupBox1.Controls.Add(this.chk_teleportation);
            this.groupBox1.Controls.Add(this.chk_animalcommunication);
            this.groupBox1.Controls.Add(this.chk_intelligence);
            this.groupBox1.Controls.Add(this.chk_invulnerable);
            this.groupBox1.Controls.Add(this.chk_agility);
            this.groupBox1.Controls.Add(this.chk_healing);
            this.groupBox1.Controls.Add(this.chk_invisible);
            this.groupBox1.Controls.Add(this.chk_strength);
            this.groupBox1.Controls.Add(this.chk_flight);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Abilities";
            // 
            // chk_flight
            // 
            this.chk_flight.AutoSize = true;
            this.chk_flight.Location = new System.Drawing.Point(6, 19);
            this.chk_flight.Name = "chk_flight";
            this.chk_flight.Size = new System.Drawing.Size(51, 17);
            this.chk_flight.TabIndex = 0;
            this.chk_flight.Text = "Flight";
            this.chk_flight.UseVisualStyleBackColor = true;
            // 
            // chk_strength
            // 
            this.chk_strength.AutoSize = true;
            this.chk_strength.Location = new System.Drawing.Point(6, 42);
            this.chk_strength.Name = "chk_strength";
            this.chk_strength.Size = new System.Drawing.Size(97, 17);
            this.chk_strength.TabIndex = 1;
            this.chk_strength.Text = "Super Strength";
            this.chk_strength.UseVisualStyleBackColor = true;
            // 
            // chk_invisible
            // 
            this.chk_invisible.AutoSize = true;
            this.chk_invisible.Location = new System.Drawing.Point(6, 65);
            this.chk_invisible.Name = "chk_invisible";
            this.chk_invisible.Size = new System.Drawing.Size(70, 17);
            this.chk_invisible.TabIndex = 2;
            this.chk_invisible.Text = "Invisibility";
            this.chk_invisible.UseVisualStyleBackColor = true;
            // 
            // chk_healing
            // 
            this.chk_healing.AutoSize = true;
            this.chk_healing.Location = new System.Drawing.Point(6, 88);
            this.chk_healing.Name = "chk_healing";
            this.chk_healing.Size = new System.Drawing.Size(85, 17);
            this.chk_healing.TabIndex = 3;
            this.chk_healing.Text = "Fast Healing";
            this.chk_healing.UseVisualStyleBackColor = true;
            // 
            // chk_agility
            // 
            this.chk_agility.AutoSize = true;
            this.chk_agility.Location = new System.Drawing.Point(6, 111);
            this.chk_agility.Name = "chk_agility";
            this.chk_agility.Size = new System.Drawing.Size(53, 17);
            this.chk_agility.TabIndex = 4;
            this.chk_agility.Text = "Agility";
            this.chk_agility.UseVisualStyleBackColor = true;
            // 
            // chk_invulnerable
            // 
            this.chk_invulnerable.AutoSize = true;
            this.chk_invulnerable.Location = new System.Drawing.Point(6, 134);
            this.chk_invulnerable.Name = "chk_invulnerable";
            this.chk_invulnerable.Size = new System.Drawing.Size(84, 17);
            this.chk_invulnerable.TabIndex = 5;
            this.chk_invulnerable.Text = "Invulnerable";
            this.chk_invulnerable.UseVisualStyleBackColor = true;
            // 
            // chk_intelligence
            // 
            this.chk_intelligence.AutoSize = true;
            this.chk_intelligence.Location = new System.Drawing.Point(116, 19);
            this.chk_intelligence.Name = "chk_intelligence";
            this.chk_intelligence.Size = new System.Drawing.Size(111, 17);
            this.chk_intelligence.TabIndex = 6;
            this.chk_intelligence.Text = "Super Intelligence";
            this.chk_intelligence.UseVisualStyleBackColor = true;
            // 
            // chk_animalcommunication
            // 
            this.chk_animalcommunication.AutoSize = true;
            this.chk_animalcommunication.Location = new System.Drawing.Point(116, 42);
            this.chk_animalcommunication.Name = "chk_animalcommunication";
            this.chk_animalcommunication.Size = new System.Drawing.Size(132, 17);
            this.chk_animalcommunication.TabIndex = 7;
            this.chk_animalcommunication.Text = "Animal Communication";
            this.chk_animalcommunication.UseVisualStyleBackColor = true;
            // 
            // chk_teleportation
            // 
            this.chk_teleportation.AutoSize = true;
            this.chk_teleportation.Location = new System.Drawing.Point(116, 65);
            this.chk_teleportation.Name = "chk_teleportation";
            this.chk_teleportation.Size = new System.Drawing.Size(88, 17);
            this.chk_teleportation.TabIndex = 8;
            this.chk_teleportation.Text = "Teleportation";
            this.chk_teleportation.UseVisualStyleBackColor = true;
            // 
            // chk_claws
            // 
            this.chk_claws.AutoSize = true;
            this.chk_claws.Location = new System.Drawing.Point(116, 88);
            this.chk_claws.Name = "chk_claws";
            this.chk_claws.Size = new System.Drawing.Size(88, 17);
            this.chk_claws.TabIndex = 9;
            this.chk_claws.Text = "Claws/Fangs";
            this.chk_claws.UseVisualStyleBackColor = true;
            // 
            // chk_telepathy
            // 
            this.chk_telepathy.AutoSize = true;
            this.chk_telepathy.Location = new System.Drawing.Point(116, 111);
            this.chk_telepathy.Name = "chk_telepathy";
            this.chk_telepathy.Size = new System.Drawing.Size(131, 17);
            this.chk_telepathy.TabIndex = 10;
            this.chk_telepathy.Text = "Telepathy/Telekinesis";
            this.chk_telepathy.UseVisualStyleBackColor = true;
            // 
            // chk_weapons
            // 
            this.chk_weapons.AutoSize = true;
            this.chk_weapons.Location = new System.Drawing.Point(116, 134);
            this.chk_weapons.Name = "chk_weapons";
            this.chk_weapons.Size = new System.Drawing.Size(105, 17);
            this.chk_weapons.TabIndex = 11;
            this.chk_weapons.Text = "Weapons Expert";
            this.chk_weapons.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(682, 406);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(106, 32);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Hero!";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_weapons;
        private System.Windows.Forms.CheckBox chk_telepathy;
        private System.Windows.Forms.CheckBox chk_claws;
        private System.Windows.Forms.CheckBox chk_teleportation;
        private System.Windows.Forms.CheckBox chk_animalcommunication;
        private System.Windows.Forms.CheckBox chk_intelligence;
        private System.Windows.Forms.CheckBox chk_invulnerable;
        private System.Windows.Forms.CheckBox chk_agility;
        private System.Windows.Forms.CheckBox chk_healing;
        private System.Windows.Forms.CheckBox chk_invisible;
        private System.Windows.Forms.CheckBox chk_strength;
        private System.Windows.Forms.CheckBox chk_flight;
        private System.Windows.Forms.Button btn_create;
    }
}

