using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using FaceRecognitionPhoto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognitionPhoto
{
    public partial class FaceRecognitionForm : Form
    {
        BusinessRecognition recognition = new BusinessRecognition("D:\\", "Faces", "face.xml");
        Classifier_Train train = new Classifier_Train("D:\\", "Faces", "face.xml");
        Capture capture = new Capture();
        public FaceRecognitionForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void btnEducate_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!recognition.SaveTrainingData(pictureBox2.Image, txtFaceName.Text)) MessageBox.Show("Hata", "There was istake while take photo from camera.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(100);
                    lblEgitilenAdet.Text = (i + 1) + " took photo.";
                }


                recognition = null;
                train = null;

                recognition = new BusinessRecognition("D:\\", "Faces", "face.xml");
                train = new Classifier_Train("D:\\", "Faces", "face.xml");
            });
        }

        private void FaceRecognitionForm_Load(object sender, EventArgs e)
        {            
            capture.Start();
            capture.ImageGrabbed += (a, b) =>
            {
                var image = capture.RetrieveBgrFrame();
                var grayimage = image.Convert<Gray, byte>();
                HaarCascade haarface = new HaarCascade("haarcascade_frontalface_alt2.xml");
                MCvAvgComp[][] faces = grayimage.DetectHaarCascade(haarface, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                foreach (MCvAvgComp item in faces[0])
                {
                    var face = grayimage.Copy(item.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    pictureBox2.Image = face.ToBitmap();
                    if (train != null)
                        if (train.IsTrained)
                        {
                            string name = train.Recognise(face);
                            int match_value = (int)train.Get_Eigen_Distance;
                            image.Draw(name + " ", ref font, new Point(item.rect.X - 2, item.rect.Y - 2), new Bgr(Color.LightGreen));
                        }
                    image.Draw(item.rect, new Bgr(Color.Red), 2);
                }
                pictureBox1.Image = image.ToBitmap();
            };
        }

        private void btnDeleteEducate_Click(object sender, EventArgs e)
        {
            recognition.DeleteDatas();
        }

        private void FaceRecognitionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture.Stop();
        }
    }
}
