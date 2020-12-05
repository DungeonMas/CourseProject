namespace MyEnigma
{
    partial class Img_Form
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
            this.user_image_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_image_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // user_image_pb
            // 
            this.user_image_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_image_pb.Location = new System.Drawing.Point(12, 12);
            this.user_image_pb.Name = "user_image_pb";
            this.user_image_pb.Size = new System.Drawing.Size(772, 506);
            this.user_image_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_image_pb.TabIndex = 0;
            this.user_image_pb.TabStop = false;
            this.user_image_pb.Click += new System.EventHandler(this.user_image_pb_Click);
            // 
            // Img_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(796, 530);
            this.Controls.Add(this.user_image_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Img_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Img_Form";
            ((System.ComponentModel.ISupportInitialize)(this.user_image_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox user_image_pb;
    }
}