using Emgu.CV;
using Emgu.CV.CvEnum;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Capture capture = new Capture();
            capture.Start();

            HaarCascade haarface = new HaarCascade("haarcascade_frontalface_default.xml");
            HaarCascade haareye = new HaarCascade("haarcascade_eye.xml");
            HaarCascade haarmouth = new HaarCascade("haarcascade_mcs_mouth.xml");
            HaarCascade haarnose = new HaarCascade("haarcascade_mcs_nose.xml");

            capture.ImageGrabbed += (x, y) =>
            {
                var image = capture.RetrieveBgrFrame();
                if (image != null)
                {
                    //Camera image converting to <Gray,byte>
                    var grayimage = image.Convert<Gray, byte>();
                    
                    MCvAvgComp[][] Faces = grayimage.DetectHaarCascade(haarface, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvAvgComp[][] Eyes = grayimage.DetectHaarCascade(haareye, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvAvgComp[][] Mouthes = grayimage.DetectHaarCascade(haarmouth, 1.2, 100, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvAvgComp[][] Noses = grayimage.DetectHaarCascade(haarnose, 1.2, 50, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));

                    //Making object coordinate and drawing
                    foreach (MCvAvgComp hFAce in Faces[0])
                    {
                        image.Draw(hFAce.rect, new Bgr(Color.Red), 2);

                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.3, 0.3);

                        //Typing object name for object what it found
                        image.Draw("Face", ref font, new Point(hFAce.rect.X, hFAce.rect.Y), new Bgr(Color.Yellow));
                    }
                    foreach (MCvAvgComp eye in Eyes[0])
                    {
                        image.Draw(eye.rect, new Bgr(Color.Blue), 2);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.3, 0.3);

                        //Typing object name for object what it found
                        image.Draw("Eye", ref font, new Point(eye.rect.X, eye.rect.Y), new Bgr(Color.Yellow));
                    }
                    foreach (MCvAvgComp mouth in Mouthes[0])
                    {
                        image.Draw(mouth.rect, new Bgr(Color.Gray), 2);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.3, 0.3);

                        //Typing object name for object what it found
                        image.Draw("Mouth", ref font, new Point(mouth.rect.X, mouth.rect.Y), new Bgr(Color.Yellow));
                    }
                    foreach (MCvAvgComp nose in Noses[0])
                    {
                        image.Draw(nose.rect, new Bgr(Color.Orange), 2);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.3, 0.3);

                        //Typing object name for object what it found
                        image.Draw("Nose", ref font, new Point(nose.rect.X, nose.rect.Y), new Bgr(Color.Yellow));
                    }
                }
                pictureBox1.Image = image.ToBitmap();
            };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Capture capture = new Capture();
            capture.Stop();
        }
    }
}
