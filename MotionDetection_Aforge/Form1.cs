using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionDetection_Aforge
{
    public partial class Form1 : Form
    {
        VideoCaptureDevice FinalVideoSource;
        FilterInfoCollection VideoCaptuerDevices;
        MotionDetector detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting { HighlightColor = Color.Red });        
        public Form1()
        {
            InitializeComponent();
        }
        public void GetCamera()
        {           
            VideoCaptuerDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            FinalVideoSource = new VideoCaptureDevice(VideoCaptuerDevices[0].MonikerString);
            FinalVideoSource.NewFrame += FinalVideoSource_NewFrame;
            FinalVideoSource.DesiredFrameRate = 500;
            FinalVideoSource.DesiredFrameSize = new Size(1, 500);
            FinalVideoSource.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetCamera();
        }
       
        private void FinalVideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();           
            //Hareket var mı? kontrol edilir. Varsa eğer image üzerinde algoritmalara uygun çalışma gerçekleştirilir.
            if (detector.ProcessFrame(image) > 0.02)
            {
                //Eğer hareket algılanırsa burası tetiklenir.
                pictureBox1.Image = image;
                //Haliyle çalışma yapılmış o anki görüntü PictureBox nesnesine aktarılır.
            }
            pictureBox1.Image = image;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalVideoSource.Stop();
        }
    }
}
