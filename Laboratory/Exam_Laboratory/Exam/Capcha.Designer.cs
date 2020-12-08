namespace Exam
{
    partial class Capcha
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
            this.label1 = new System.Windows.Forms.Label();
            this.capcha_label = new System.Windows.Forms.Label();
            this.reload_capcha_label = new System.Windows.Forms.Label();
            this.capcha_textBox = new System.Windows.Forms.TextBox();
            this.complete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст с картинки";
            // 
            // capcha_label
            // 
            this.capcha_label.AutoSize = true;
            this.capcha_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.capcha_label.Font = new System.Drawing.Font("Bradley Hand ITC", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capcha_label.Location = new System.Drawing.Point(86, 80);
            this.capcha_label.Name = "capcha_label";
            this.capcha_label.Size = new System.Drawing.Size(123, 47);
            this.capcha_label.TabIndex = 1;
            this.capcha_label.Text = "label2";
            // 
            // reload_capcha_label
            // 
            this.reload_capcha_label.AutoSize = true;
            this.reload_capcha_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reload_capcha_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload_capcha_label.Location = new System.Drawing.Point(77, 152);
            this.reload_capcha_label.Name = "reload_capcha_label";
            this.reload_capcha_label.Size = new System.Drawing.Size(141, 20);
            this.reload_capcha_label.TabIndex = 2;
            this.reload_capcha_label.Text = "Я не вижу код";
            this.reload_capcha_label.Click += new System.EventHandler(this.reload_capcha_label_Click);
            // 
            // capcha_textBox
            // 
            this.capcha_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capcha_textBox.Location = new System.Drawing.Point(54, 194);
            this.capcha_textBox.Name = "capcha_textBox";
            this.capcha_textBox.Size = new System.Drawing.Size(192, 28);
            this.capcha_textBox.TabIndex = 3;
            // 
            // complete_Button
            // 
            this.complete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complete_Button.Location = new System.Drawing.Point(81, 260);
            this.complete_Button.Name = "complete_Button";
            this.complete_Button.Size = new System.Drawing.Size(146, 45);
            this.complete_Button.TabIndex = 4;
            this.complete_Button.Text = "Отправить";
            this.complete_Button.UseVisualStyleBackColor = true;
            this.complete_Button.Click += new System.EventHandler(this.complete_Button_Click);
            // 
            // Capcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 333);
            this.Controls.Add(this.complete_Button);
            this.Controls.Add(this.capcha_textBox);
            this.Controls.Add(this.reload_capcha_label);
            this.Controls.Add(this.capcha_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Capcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка ";
            this.Load += new System.EventHandler(this.Capcha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label capcha_label;
        private System.Windows.Forms.Label reload_capcha_label;
        private System.Windows.Forms.TextBox capcha_textBox;
        private System.Windows.Forms.Button complete_Button;
    }
}