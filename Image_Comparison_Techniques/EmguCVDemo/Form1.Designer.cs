namespace EmguCVDemo
{
    partial class EmguCVDemo
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pbLoadImage = new System.Windows.Forms.PictureBox();
            this.pbConvertedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // pbLoadImage
            // 
            this.pbLoadImage.Location = new System.Drawing.Point(12, 42);
            this.pbLoadImage.Name = "pbLoadImage";
            this.pbLoadImage.Size = new System.Drawing.Size(411, 301);
            this.pbLoadImage.TabIndex = 1;
            this.pbLoadImage.TabStop = false;
            // 
            // pbConvertedImage
            // 
            this.pbConvertedImage.Location = new System.Drawing.Point(442, 42);
            this.pbConvertedImage.Name = "pbConvertedImage";
            this.pbConvertedImage.Size = new System.Drawing.Size(422, 301);
            this.pbConvertedImage.TabIndex = 2;
            this.pbConvertedImage.TabStop = false;
            // 
            // EmguCVDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 397);
            this.Controls.Add(this.pbConvertedImage);
            this.Controls.Add(this.pbLoadImage);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "EmguCVDemo";
            this.Text = "EmguCV Demo App";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pbLoadImage;
        private System.Windows.Forms.PictureBox pbConvertedImage;
    }
}

