using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace EmguCVDemo
{
    public partial class EmguCVDemo : Form
    {
        public EmguCVDemo()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            var Openfile = new OpenFileDialog();

            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                var My_Image = new Image<Bgr, byte>(Openfile.FileName);
                pbLoadImage.Image = My_Image.ToBitmap();

                var Converted_Image = My_Image.Convert<Gray, byte>();
                pbConvertedImage.Image = Converted_Image.ToBitmap();
            }
        }
    }
}
