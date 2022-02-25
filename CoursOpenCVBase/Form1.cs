using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace CoursOpenCVBase
{
    public partial class Form1 : Form
    {
        string path = @"lena.jpg";
        Image<Bgr, Byte> image;
        Image<Gray, Byte> gray;
        Mat imgGray;
        CascadeClassifier face;
        CascadeClassifier eyes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image = new Image<Bgr, Byte>(path);
            gray = image.Convert<Gray, Byte>();
            // initialisation xml
            face = new CascadeClassifier(@"haarcascade_frontalface_alt.xml");
            eyes = new CascadeClassifier(@"haarcascade_eye.xml");
            /*pbImage.Image = image.ToBitmap();
            Image<Gray, Byte> gray = image.Convert<Gray, Byte>();
            pbTraitement.Image = gray.ToBitmap();
            */

            // 2eme méthode : Convertis initial en niveau de gris

            UMat imageTest = image.ToUMat();
            imgGray = new Mat();
            CvInvoke.CvtColor(imageTest, imgGray, ColorConversion.Bgr2Gray);
           
            pbImage.Image = imgGray.ToImage<Gray, Byte>().ToBitmap();


            // EqualizeHeight
            equalizeHist();

        }
        private void equalizeHist()
        {
            Mat dst = new Mat();
            CvInvoke.EqualizeHist(imgGray, dst);
            pbTraitement.Image = dst.ToImage<Gray, Byte>().ToBitmap();
        }
        private void threshold()
        {
            Mat dst = new Mat();
            int type = tbType.Value;
            CvInvoke.Threshold(imgGray,dst,tbSeuil.Value,255, (ThresholdType)type);
            pbTraitement.Image = dst.ToImage<Gray, Byte>().ToBitmap();
        }


        private void tbSeuil_Scroll(object sender, EventArgs e)
        {
            threshold();
        }

        private void tbType_Scroll(object sender, EventArgs e)
        {
            threshold();

        }

        private void btnVisage_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> imageTravail = gray.ToUMat().ToImage<Gray, Byte>();

            Rectangle[] facesDetected = face.DetectMultiScale(gray, 1.1, 10, new Size(20, 20));

            foreach(Rectangle rFace in facesDetected)
            {
                imageTravail.Draw(rFace, new Gray(), 4);
                gray.ROI = rFace;

                Rectangle[] eyesDetected = eyes.DetectMultiScale(gray, 1.1, 10, new Size(5, 5));

                foreach (Rectangle eyeRect in eyesDetected)
                {
                    eyeRect.Offset(rFace.X, rFace.Y);
                    imageTravail.Draw(eyeRect, new Gray(), 4);
                }

            }
            pbTraitement2.Image = imageTravail.ToBitmap();
        }
    }
}
