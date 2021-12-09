# Deteccionfaciall
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;

namespace DeteccionFacial
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        FaceRec faceRec = new FaceRec();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            faceRec.openCamera(pictureBox1, pictureBox2);
        }

        private void ProccessFrame(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(textBox1.Text);
            MessageBox.Show("Imagen Guardado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }
    }
}
