namespace MyEnigma
{
    partial class Enigma
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enigma));
            this.input_textBox = new System.Windows.Forms.RichTextBox();
            this.output_textBox = new System.Windows.Forms.RichTextBox();
            this.rot_3_lbl = new System.Windows.Forms.Label();
            this.rot_2_lbl = new System.Windows.Forms.Label();
            this.rot_1_lbl = new System.Windows.Forms.Label();
            this.openFile_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveInFile_Button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gee = new System.Windows.Forms.GroupBox();
            this.rotor1_lbl = new System.Windows.Forms.Label();
            this.rotor2_lbl = new System.Windows.Forms.Label();
            this.rotor3_lbl = new System.Windows.Forms.Label();
            this.rot_1_dec_button = new System.Windows.Forms.Button();
            this.rot_3_dec_button = new System.Windows.Forms.Button();
            this.rot_2_dec_button = new System.Windows.Forms.Button();
            this.rot_3_inc_button = new System.Windows.Forms.Button();
            this.rot_1_inc_button = new System.Windows.Forms.Button();
            this.rot_2_inc_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pasteText_Button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.clearAll_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.aboutEnigma_Button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reflectorLabel = new System.Windows.Forms.Label();
            this.gee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_textBox.Location = new System.Drawing.Point(39, 48);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(600, 96);
            this.input_textBox.TabIndex = 0;
            this.input_textBox.Text = "";
            this.input_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_textBox_KeyDown);
            this.input_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_textBox_KeyPress);
            // 
            // output_textBox
            // 
            this.output_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_textBox.Location = new System.Drawing.Point(39, 190);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(600, 96);
            this.output_textBox.TabIndex = 1;
            this.output_textBox.Text = "";
            // 
            // rot_3_lbl
            // 
            this.rot_3_lbl.AutoSize = true;
            this.rot_3_lbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rot_3_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rot_3_lbl.Location = new System.Drawing.Point(98, 296);
            this.rot_3_lbl.Name = "rot_3_lbl";
            this.rot_3_lbl.Size = new System.Drawing.Size(36, 35);
            this.rot_3_lbl.TabIndex = 2;
            this.rot_3_lbl.Text = "A";
            // 
            // rot_2_lbl
            // 
            this.rot_2_lbl.AutoSize = true;
            this.rot_2_lbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rot_2_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rot_2_lbl.Location = new System.Drawing.Point(98, 188);
            this.rot_2_lbl.Name = "rot_2_lbl";
            this.rot_2_lbl.Size = new System.Drawing.Size(36, 35);
            this.rot_2_lbl.TabIndex = 3;
            this.rot_2_lbl.Text = "A";
            // 
            // rot_1_lbl
            // 
            this.rot_1_lbl.AutoSize = true;
            this.rot_1_lbl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rot_1_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rot_1_lbl.Location = new System.Drawing.Point(98, 77);
            this.rot_1_lbl.Name = "rot_1_lbl";
            this.rot_1_lbl.Size = new System.Drawing.Size(36, 35);
            this.rot_1_lbl.TabIndex = 4;
            this.rot_1_lbl.Text = "A";
            this.rot_1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFile_button
            // 
            this.openFile_button.Location = new System.Drawing.Point(23, 33);
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(202, 29);
            this.openFile_button.TabIndex = 5;
            this.openFile_button.Text = "Открыть файл";
            this.openFile_button.UseVisualStyleBackColor = true;
            this.openFile_button.Click += new System.EventHandler(this.openFile_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveInFile_Button
            // 
            this.saveInFile_Button.Location = new System.Drawing.Point(23, 77);
            this.saveInFile_Button.Name = "saveInFile_Button";
            this.saveInFile_Button.Size = new System.Drawing.Size(202, 29);
            this.saveInFile_Button.TabIndex = 6;
            this.saveInFile_Button.Text = "Сохранить в файл";
            this.saveInFile_Button.UseVisualStyleBackColor = true;
            this.saveInFile_Button.Click += new System.EventHandler(this.saveInFile_Button_Click);
            // 
            // gee
            // 
            this.gee.BackColor = System.Drawing.Color.Gainsboro;
            this.gee.Controls.Add(this.rotor1_lbl);
            this.gee.Controls.Add(this.rotor2_lbl);
            this.gee.Controls.Add(this.rotor3_lbl);
            this.gee.Controls.Add(this.rot_1_dec_button);
            this.gee.Controls.Add(this.rot_1_lbl);
            this.gee.Controls.Add(this.rot_3_dec_button);
            this.gee.Controls.Add(this.rot_2_dec_button);
            this.gee.Controls.Add(this.rot_3_inc_button);
            this.gee.Controls.Add(this.rot_1_inc_button);
            this.gee.Controls.Add(this.rot_2_lbl);
            this.gee.Controls.Add(this.rot_2_inc_button);
            this.gee.Controls.Add(this.rot_3_lbl);
            this.gee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gee.Location = new System.Drawing.Point(1042, 141);
            this.gee.Name = "gee";
            this.gee.Size = new System.Drawing.Size(237, 366);
            this.gee.TabIndex = 7;
            this.gee.TabStop = false;
            this.gee.Text = "Позиции роторов";
            // 
            // rotor1_lbl
            // 
            this.rotor1_lbl.AutoSize = true;
            this.rotor1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotor1_lbl.Location = new System.Drawing.Point(99, 37);
            this.rotor1_lbl.Name = "rotor1_lbl";
            this.rotor1_lbl.Size = new System.Drawing.Size(17, 25);
            this.rotor1_lbl.TabIndex = 13;
            this.rotor1_lbl.Text = "I";
            // 
            // rotor2_lbl
            // 
            this.rotor2_lbl.AutoSize = true;
            this.rotor2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotor2_lbl.Location = new System.Drawing.Point(99, 146);
            this.rotor2_lbl.Name = "rotor2_lbl";
            this.rotor2_lbl.Size = new System.Drawing.Size(22, 25);
            this.rotor2_lbl.TabIndex = 12;
            this.rotor2_lbl.Text = "II";
            // 
            // rotor3_lbl
            // 
            this.rotor3_lbl.AutoSize = true;
            this.rotor3_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotor3_lbl.Location = new System.Drawing.Point(99, 254);
            this.rotor3_lbl.Name = "rotor3_lbl";
            this.rotor3_lbl.Size = new System.Drawing.Size(27, 25);
            this.rotor3_lbl.TabIndex = 11;
            this.rotor3_lbl.Text = "III";
            // 
            // rot_1_dec_button
            // 
            this.rot_1_dec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rot_1_dec_button.Location = new System.Drawing.Point(19, 291);
            this.rot_1_dec_button.Name = "rot_1_dec_button";
            this.rot_1_dec_button.Size = new System.Drawing.Size(45, 45);
            this.rot_1_dec_button.TabIndex = 10;
            this.rot_1_dec_button.Text = "-";
            this.rot_1_dec_button.UseVisualStyleBackColor = true;
            this.rot_1_dec_button.Click += new System.EventHandler(this.rot_1_dec_button_Click);
            // 
            // rot_3_dec_button
            // 
            this.rot_3_dec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rot_3_dec_button.Location = new System.Drawing.Point(19, 72);
            this.rot_3_dec_button.Name = "rot_3_dec_button";
            this.rot_3_dec_button.Size = new System.Drawing.Size(45, 45);
            this.rot_3_dec_button.TabIndex = 8;
            this.rot_3_dec_button.Text = "-";
            this.rot_3_dec_button.UseVisualStyleBackColor = true;
            this.rot_3_dec_button.Click += new System.EventHandler(this.rot_3_dec_button_Click);
            // 
            // rot_2_dec_button
            // 
            this.rot_2_dec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rot_2_dec_button.Location = new System.Drawing.Point(19, 183);
            this.rot_2_dec_button.Name = "rot_2_dec_button";
            this.rot_2_dec_button.Size = new System.Drawing.Size(45, 45);
            this.rot_2_dec_button.TabIndex = 9;
            this.rot_2_dec_button.Text = "-";
            this.rot_2_dec_button.UseVisualStyleBackColor = true;
            this.rot_2_dec_button.Click += new System.EventHandler(this.rot_2_dec_button_Click);
            // 
            // rot_3_inc_button
            // 
            this.rot_3_inc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rot_3_inc_button.Location = new System.Drawing.Point(173, 72);
            this.rot_3_inc_button.Name = "rot_3_inc_button";
            this.rot_3_inc_button.Size = new System.Drawing.Size(45, 44);
            this.rot_3_inc_button.TabIndex = 5;
            this.rot_3_inc_button.Text = "+";
            this.rot_3_inc_button.UseVisualStyleBackColor = true;
            this.rot_3_inc_button.Click += new System.EventHandler(this.rot_3_inc_button_Click);
            // 
            // rot_1_inc_button
            // 
            this.rot_1_inc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rot_1_inc_button.Location = new System.Drawing.Point(173, 291);
            this.rot_1_inc_button.Name = "rot_1_inc_button";
            this.rot_1_inc_button.Size = new System.Drawing.Size(45, 45);
            this.rot_1_inc_button.TabIndex = 7;
            this.rot_1_inc_button.Text = "+";
            this.rot_1_inc_button.UseVisualStyleBackColor = true;
            this.rot_1_inc_button.Click += new System.EventHandler(this.rot_1_inc_button_Click);
            // 
            // rot_2_inc_button
            // 
            this.rot_2_inc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rot_2_inc_button.Location = new System.Drawing.Point(173, 183);
            this.rot_2_inc_button.Name = "rot_2_inc_button";
            this.rot_2_inc_button.Size = new System.Drawing.Size(45, 45);
            this.rot_2_inc_button.TabIndex = 6;
            this.rot_2_inc_button.Text = "+";
            this.rot_2_inc_button.UseVisualStyleBackColor = true;
            this.rot_2_inc_button.Click += new System.EventHandler(this.rot_2_inc_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pasteText_Button);
            this.groupBox2.Controls.Add(this.copy_button);
            this.groupBox2.Controls.Add(this.clearAll_Button);
            this.groupBox2.Controls.Add(this.input_textBox);
            this.groupBox2.Controls.Add(this.output_textBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(320, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 366);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод и вывод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(561, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вывод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(573, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ввод";
            // 
            // pasteText_Button
            // 
            this.pasteText_Button.Location = new System.Drawing.Point(39, 155);
            this.pasteText_Button.Name = "pasteText_Button";
            this.pasteText_Button.Size = new System.Drawing.Size(182, 29);
            this.pasteText_Button.TabIndex = 7;
            this.pasteText_Button.Text = "Вставить текст";
            this.pasteText_Button.UseVisualStyleBackColor = true;
            this.pasteText_Button.Click += new System.EventHandler(this.pasteText_Button_Click);
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(39, 314);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(182, 32);
            this.copy_button.TabIndex = 3;
            this.copy_button.Text = "Копировать текст";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // clearAll_Button
            // 
            this.clearAll_Button.Location = new System.Drawing.Point(457, 314);
            this.clearAll_Button.Name = "clearAll_Button";
            this.clearAll_Button.Size = new System.Drawing.Size(182, 32);
            this.clearAll_Button.TabIndex = 2;
            this.clearAll_Button.Text = "Очистить всё";
            this.clearAll_Button.UseVisualStyleBackColor = true;
            this.clearAll_Button.Click += new System.EventHandler(this.clearAll_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(698, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "ENIGMA MACHINE EMULATOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 100);
            this.panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.openFile_button);
            this.groupBox3.Controls.Add(this.saveInFile_Button);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(25, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 124);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Работа с файлами";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.aboutEnigma_Button);
            this.groupBox4.Controls.Add(this.settings_button);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(25, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 137);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прочее";
            // 
            // aboutEnigma_Button
            // 
            this.aboutEnigma_Button.Location = new System.Drawing.Point(23, 88);
            this.aboutEnigma_Button.Name = "aboutEnigma_Button";
            this.aboutEnigma_Button.Size = new System.Drawing.Size(202, 29);
            this.aboutEnigma_Button.TabIndex = 8;
            this.aboutEnigma_Button.Text = "Об энигме";
            this.aboutEnigma_Button.UseVisualStyleBackColor = true;
            this.aboutEnigma_Button.Click += new System.EventHandler(this.aboutEnigma_Button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(23, 42);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(202, 29);
            this.settings_button.TabIndex = 7;
            this.settings_button.Text = "Настройки";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.reflectorLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 61);
            this.panel2.TabIndex = 13;
            // 
            // reflectorLabel
            // 
            this.reflectorLabel.AutoSize = true;
            this.reflectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reflectorLabel.Location = new System.Drawing.Point(12, 17);
            this.reflectorLabel.Name = "reflectorLabel";
            this.reflectorLabel.Size = new System.Drawing.Size(0, 25);
            this.reflectorLabel.TabIndex = 0;
            // 
            // Enigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enigma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gee.ResumeLayout(false);
            this.gee.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_textBox;
        private System.Windows.Forms.RichTextBox output_textBox;
        private System.Windows.Forms.Label rot_3_lbl;
        private System.Windows.Forms.Label rot_2_lbl;
        private System.Windows.Forms.Label rot_1_lbl;
        private System.Windows.Forms.Button openFile_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveInFile_Button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gee;
        private System.Windows.Forms.Button rot_1_dec_button;
        private System.Windows.Forms.Button rot_2_dec_button;
        private System.Windows.Forms.Button rot_3_dec_button;
        private System.Windows.Forms.Button rot_1_inc_button;
        private System.Windows.Forms.Button rot_2_inc_button;
        private System.Windows.Forms.Button rot_3_inc_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clearAll_Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button aboutEnigma_Button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label reflectorLabel;
        private System.Windows.Forms.Button copy_button;
        public System.Windows.Forms.Label rotor1_lbl;
        public System.Windows.Forms.Label rotor2_lbl;
        public System.Windows.Forms.Label rotor3_lbl;
        private System.Windows.Forms.Button pasteText_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

