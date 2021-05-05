using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class ProcessingForm : Form
    {
        FilterInfoCollection webcam;
        VideoCaptureDevice cam;
        public ProcessingForm()
        {
            InitializeComponent();
        }
        private void NewCam(object sender, NewFrameEventArgs eventArgs)
        {
            picBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in webcam)
            {
                cmbCamera.Items.Add(dev.Name);
            }
            cmbCamera.SelectedIndex = 0;

            cam = new VideoCaptureDevice(webcam[cmbCamera.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(NewCam);
            cam.Start();
        }
        private void ProcessingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
        }

        private void btnCatchImage_Click(object sender, EventArgs e)
        {
            picBoxImage.Image = picBoxCamera.Image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.BMP;*.PNG;*.JPG;*.JPEG;*.GIF)|*.BMP;*.PNG;*.JPG;*.JPEG;*.GIF";
            DialogResult dialogResult = saveFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                picBoxImage.Image.Save(saveFile.FileName);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.BMP;*.PNG;*.JPG;*.JPEG;*.GIF)|*.BMP;*.PNG;*.JPG;*.JPEG;*.GIF";
            DialogResult dialogResult = openFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                picBoxUpload.ImageLocation = openFile.FileName;
            }
        }
    }
}
