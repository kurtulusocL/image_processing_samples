using ImageProcessing_EmguCV.Forms;
using ImageProcessing_EmguCV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing_EmguCV
{
    public partial class Form1 : Form
    {
        Business business = new Business();
        WithoutColor sincolor = new WithoutColor();
        OpenFileDialog openFile = new OpenFileDialog();
        Esikleme esik = new Esikleme();
        Shining parla = new Shining();
        public Form1()
        {
            InitializeComponent();
        }

        private void processingHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ımageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            label3.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bitmap;
            bitmap = (Bitmap)pictureBox1.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);
            pictureBox2.BackColor = color;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Bitmap uploadedPhoto = business.Negative((Bitmap)(pictureBox1.Image));
            pictureBox2.Image = uploadedPhoto;

            Bitmap orijinal = (Bitmap)pictureBox1.Image;
            Bitmap uploadPhoto = null;

            switch (comboBox1.SelectedItem)
            {
                case "negatif":
                    uploadPhoto = business.Negative((Bitmap)orijinal);
                    break;
                case "gri":
                    uploadPhoto = sincolor.ConvertToGrey((Bitmap)orijinal);
                    break;
                case "eşikleme":
                    uploadPhoto = sincolor.ConvertToGrey((Bitmap)orijinal);
                    uploadPhoto = esik.Esikle((Bitmap)orijinal, 128);
                    break;
                case "parlaklık":
                    uploadPhoto = parla.Parlaklık((Bitmap)orijinal, trackBar1.Value);
                    break;
            }
            pictureBox2.Image = uploadPhoto;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "mouse mode")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.BackColor = Color.Lavender;
            }
        }
    }
}
