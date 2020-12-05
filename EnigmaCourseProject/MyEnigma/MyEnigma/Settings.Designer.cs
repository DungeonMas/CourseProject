namespace MyEnigma
{
    partial class Settings
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
            this.reflector_comboBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.reflector_textBox = new System.Windows.Forms.TextBox();
            this.comboBox_Rotor1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Rotor2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Rotor3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rot_1_alpha_textBox = new System.Windows.Forms.TextBox();
            this.rot_2_alpha_textBox = new System.Windows.Forms.TextBox();
            this.rot_3_alpha_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reflector_comboBox
            // 
            this.reflector_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reflector_comboBox.FormattingEnabled = true;
            this.reflector_comboBox.Items.AddRange(new object[] {
            "Reflector А",
            "Reflector B",
            "Reflector C"});
            this.reflector_comboBox.Location = new System.Drawing.Point(35, 123);
            this.reflector_comboBox.Name = "reflector_comboBox";
            this.reflector_comboBox.Size = new System.Drawing.Size(358, 28);
            this.reflector_comboBox.TabIndex = 0;
            this.reflector_comboBox.SelectedIndexChanged += new System.EventHandler(this.reflector_comboBox_SelectedIndexChanged);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(205, 370);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(224, 32);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Сохранить изменения";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // reflector_textBox
            // 
            this.reflector_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reflector_textBox.Location = new System.Drawing.Point(35, 169);
            this.reflector_textBox.Name = "reflector_textBox";
            this.reflector_textBox.ReadOnly = true;
            this.reflector_textBox.Size = new System.Drawing.Size(358, 27);
            this.reflector_textBox.TabIndex = 2;
            // 
            // comboBox_Rotor1
            // 
            this.comboBox_Rotor1.FormattingEnabled = true;
            this.comboBox_Rotor1.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.comboBox_Rotor1.Location = new System.Drawing.Point(34, 42);
            this.comboBox_Rotor1.Name = "comboBox_Rotor1";
            this.comboBox_Rotor1.Size = new System.Drawing.Size(73, 28);
            this.comboBox_Rotor1.TabIndex = 3;
            this.comboBox_Rotor1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Rotor1_SelectedIndexChanged);
            // 
            // comboBox_Rotor2
            // 
            this.comboBox_Rotor2.FormattingEnabled = true;
            this.comboBox_Rotor2.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.comboBox_Rotor2.Location = new System.Drawing.Point(34, 134);
            this.comboBox_Rotor2.Name = "comboBox_Rotor2";
            this.comboBox_Rotor2.Size = new System.Drawing.Size(73, 28);
            this.comboBox_Rotor2.TabIndex = 4;
            this.comboBox_Rotor2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Rotor2_SelectedIndexChanged);
            // 
            // comboBox_Rotor3
            // 
            this.comboBox_Rotor3.FormattingEnabled = true;
            this.comboBox_Rotor3.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.comboBox_Rotor3.Location = new System.Drawing.Point(34, 229);
            this.comboBox_Rotor3.Name = "comboBox_Rotor3";
            this.comboBox_Rotor3.Size = new System.Drawing.Size(73, 28);
            this.comboBox_Rotor3.TabIndex = 5;
            this.comboBox_Rotor3.SelectedIndexChanged += new System.EventHandler(this.comboBox_Rotor3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rot_3_alpha_textBox);
            this.groupBox1.Controls.Add(this.rot_2_alpha_textBox);
            this.groupBox1.Controls.Add(this.rot_1_alpha_textBox);
            this.groupBox1.Controls.Add(this.comboBox_Rotor3);
            this.groupBox1.Controls.Add(this.comboBox_Rotor1);
            this.groupBox1.Controls.Add(this.comboBox_Rotor2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка роторов";
            // 
            // rot_1_alpha_textBox
            // 
            this.rot_1_alpha_textBox.Location = new System.Drawing.Point(34, 79);
            this.rot_1_alpha_textBox.Name = "rot_1_alpha_textBox";
            this.rot_1_alpha_textBox.ReadOnly = true;
            this.rot_1_alpha_textBox.Size = new System.Drawing.Size(357, 27);
            this.rot_1_alpha_textBox.TabIndex = 6;
            // 
            // rot_2_alpha_textBox
            // 
            this.rot_2_alpha_textBox.Location = new System.Drawing.Point(34, 173);
            this.rot_2_alpha_textBox.Name = "rot_2_alpha_textBox";
            this.rot_2_alpha_textBox.ReadOnly = true;
            this.rot_2_alpha_textBox.Size = new System.Drawing.Size(357, 27);
            this.rot_2_alpha_textBox.TabIndex = 7;
            // 
            // rot_3_alpha_textBox
            // 
            this.rot_3_alpha_textBox.Location = new System.Drawing.Point(34, 270);
            this.rot_3_alpha_textBox.Name = "rot_3_alpha_textBox";
            this.rot_3_alpha_textBox.ReadOnly = true;
            this.rot_3_alpha_textBox.Size = new System.Drawing.Size(357, 27);
            this.rot_3_alpha_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ротор №1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(130, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ротор №2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ротор №3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.reflector_comboBox);
            this.groupBox2.Controls.Add(this.reflector_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 320);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка рефлектора";
            // 
            // cancel_Button
            // 
            this.cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_Button.Location = new System.Drawing.Point(520, 370);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(224, 32);
            this.cancel_Button.TabIndex = 8;
            this.cancel_Button.Text = "Отмена";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox reflector_comboBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox reflector_textBox;
        public System.Windows.Forms.ComboBox comboBox_Rotor1;
        public System.Windows.Forms.ComboBox comboBox_Rotor2;
        public System.Windows.Forms.ComboBox comboBox_Rotor3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rot_3_alpha_textBox;
        private System.Windows.Forms.TextBox rot_2_alpha_textBox;
        private System.Windows.Forms.TextBox rot_1_alpha_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancel_Button;
    }
}