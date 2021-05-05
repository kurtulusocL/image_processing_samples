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

namespace FaceRecognitionPhoto
{
    public partial class Form1 : Form
    {
        Capture capture = new Capture();
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture.Start();

            HaarCascade haarFace = new HaarCascade("haarcascade_frontalface_default.xml");

            int counter = 1;
            capture.ImageGrabbed += (x, y) =>
            {
                var image = capture.RetrieveBgrFrame();
                if (image != null)
                {
                    var grayimage = image.Convert<Gray, byte>();

                    MCvAvgComp[][] faces = grayimage.DetectHaarCascade(haarFace, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));

                    foreach (MCvAvgComp face in faces[0])
                    {
                        AForge.Imaging.Filters.Crop Kes = new AForge.Imaging.Filters.Crop(face.rect);
                        Bitmap FaceImage = Kes.Apply(image.Bitmap);

                        if (counter != 7)
                        {
                            foreach (var nesne in Controls)
                            {
                                if (nesne is PictureBox pb)
                                    if (pb.Name == "p" + counter)
                                    {
                                        pb.Image = FaceImage;
                                        counter++;
                                    }
                            }
                        }
                        else
                            counter = 1;

                        //Find face
                        Graphics g = Graphics.FromImage(image.Bitmap);
                        g.DrawArc(new Pen(Color.Green, 3), face.rect, -30, 240);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.3, 0.3);
                        //type face
                        image.Draw("Face", ref font, new Point(face.rect.X + 10, face.rect.Y + 20), new Bgr(Color.Yellow));
                    }
                }
                pictureBox1.Image = image.ToBitmap();
            };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture.Stop();
        }
    }
}
