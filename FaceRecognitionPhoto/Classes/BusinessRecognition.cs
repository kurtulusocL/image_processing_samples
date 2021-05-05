using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FaceRecognitionPhoto.Classes
{
    class BusinessRecognition
    {
        string local;
        string folderName;
        string XmlDataFolder;
        public BusinessRecognition()
        {
            folderName = "TrainedFaces";
            XmlDataFolder = "TrainedLabels.xml";
            local = Application.StartupPath + "/" + folderName + "/";
        }

        public BusinessRecognition(string Dizin, string KlasorAdi)
        {
            this.local = Dizin + "/" + KlasorAdi + "/";
            Eigen_Recog = new Classifier_Train(Dizin, KlasorAdi);
        }

        public BusinessRecognition(string Dizin, string KlasorAdi, string XmlVeriDosyasi)
        {
            this.local = Dizin + "/" + KlasorAdi + "/";
            this.XmlDataFolder = XmlVeriDosyasi;
            Eigen_Recog = new Classifier_Train(Dizin, KlasorAdi, XmlVeriDosyasi);
        }

        #region Arka Arkaya 10 Görüntü Yakalamak İçin
        List<Image<Gray, byte>> resultImages = new List<Image<Gray, byte>>();

        #endregion


        #region Educate
        Classifier_Train Eigen_Recog;
        #endregion


        #region XML Data Folders
        XmlDocument doc = new XmlDocument();
        #endregion

        #region Save Data
        public bool SaveTrainingData(Image face_data, string FaceName)
        {
            try
            {
                string NAME_PERSON = FaceName;
                Random rand = new Random();
                bool file_create = true;
                string facename = "face_" + NAME_PERSON + "_" + rand.Next().ToString() + ".jpg";
                while (file_create)
                {

                    if (!File.Exists(local + facename))
                    {
                        file_create = false;
                    }
                    else
                    {
                        facename = "face_" + NAME_PERSON + "_" + rand.Next().ToString() + ".jpg";
                    }
                }


                if (Directory.Exists(local))
                {
                    //face_data.Save(local + facename, ImageFormat.Jpeg);
                }
                else
                {
                    Directory.CreateDirectory(local);
                    face_data.Save(local + facename, ImageFormat.Jpeg);
                }
                if (File.Exists(local + XmlDataFolder))
                {                   
                    bool loading = true;
                    while (loading)
                    {
                        try
                        {
                            doc.Load(local + XmlDataFolder);
                            loading = false;
                        }
                        catch
                        {
                            doc = null;
                            doc = new XmlDocument();
                            Thread.Sleep(10);
                        }
                    }

                    XmlElement root = doc.DocumentElement;

                    XmlElement face_D = doc.CreateElement("FACE");
                    XmlElement name_D = doc.CreateElement("NAME");
                    XmlElement file_D = doc.CreateElement("FILE");
                    
                    name_D.InnerText = NAME_PERSON;
                    file_D.InnerText = facename;
                   
                    face_D.AppendChild(name_D);
                    face_D.AppendChild(file_D);

                    root.AppendChild(face_D);

                    doc.Save(local + XmlDataFolder);                    
                }
                else
                {
                    FileStream FS_Face = File.OpenWrite(local + XmlDataFolder);
                    using (XmlWriter writer = XmlWriter.Create(FS_Face))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Faces_For_Training");

                        writer.WriteStartElement("FACE");
                        writer.WriteElementString("NAME", NAME_PERSON);
                        writer.WriteElementString("FILE", facename);
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    FS_Face.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion

        #region Delete Datas
        public void DeleteDatas()
        {
            if (Directory.Exists(local))
            {
                Directory.Delete(local, true);
            }
            Directory.CreateDirectory(local);
        }
        #endregion
    }
}
