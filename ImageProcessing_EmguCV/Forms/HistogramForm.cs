using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing_EmguCV.Forms
{
    public partial class HistogramForm : Form
    {
        Image<Bgr, Byte> InputImage;
        Image<Gray, Byte> GrayImage;
        public HistogramForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Filter = "Image file (*.bmp,*.png,*.jpeg,*.jpg)| *.bmp;*.png;*.jpeg;*.jpg";
            if (DialogResult.OK == opFile.ShowDialog())
            {
                InputImage = new Image<Bgr, byte>(opFile.FileName);
            }

            InputImage = new Image<Bgr, byte>(opFile.FileName);
            if (InputImage == null)
            {
                MessageBox.Show("There is not a image");
                return;
            }
            else
            {
                imageBox1.Image = InputImage;
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            GrayImage = InputImage.Convert<Gray, Byte>();
            pictureBox1.Image = GrayImage.Bitmap;
        }

        private void btnHistogram_1_Click(object sender, EventArgs e)
        {
            DenseHistogram denseHist = new DenseHistogram(256, new RangeF(0, 255));
            denseHist.Calculate(new Image<Gray, Byte>[] { InputImage[0] }, false, null);

            Mat mat = new Mat();
            denseHist.CopyTo(mat);
            histogramBox1.AddHistogram("Colorfull Image Histogram", Color.Blue, mat, 256, new float[] { 0, 256 });
            histogramBox1.Refresh();
        }

        private void btnHistogram_2_Click(object sender, EventArgs e)
        {
            DenseHistogram denseHist = new DenseHistogram(256, new RangeF(0, 255));
            denseHist.Calculate(new Image<Gray, Byte>[] { GrayImage }, false, null);

            Mat mat = new Mat();
            denseHist.CopyTo(mat);
            histogramBox2.AddHistogram("Gray Image Histogram", Color.Blue, mat, 256, new float[] { 0, 256 });
            histogramBox2.Refresh();
        }
    }
}
