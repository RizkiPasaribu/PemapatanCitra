namespace Pemapatan_Citra
{
    partial class Form1
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
            this.button_Browse = new System.Windows.Forms.Button();
            this.button_Compress = new System.Windows.Forms.Button();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(12, 8);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(140, 23);
            this.button_Browse.TabIndex = 0;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // button_Compress
            // 
            this.button_Compress.Location = new System.Drawing.Point(194, 300);
            this.button_Compress.Name = "button_Compress";
            this.button_Compress.Size = new System.Drawing.Size(147, 23);
            this.button_Compress.TabIndex = 1;
            this.button_Compress.Text = "Compress";
            this.button_Compress.UseVisualStyleBackColor = true;
            this.button_Compress.Click += new System.EventHandler(this.button_Compress_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Image.Location = new System.Drawing.Point(12, 63);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(329, 231);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image.TabIndex = 2;
            this.pictureBox_Image.TabStop = false;
            // 
            // textBox_Path
            // 
            this.textBox_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Path.Location = new System.Drawing.Point(12, 37);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(329, 20);
            this.textBox_Path.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 331);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.button_Compress);
            this.Controls.Add(this.button_Browse);
            this.Name = "Form1";
            this.Text = "Rizki Ali Akbar Pasaribu (0701192007)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Button button_Compress;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.TextBox textBox_Path;
    }
}

