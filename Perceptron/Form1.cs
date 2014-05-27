using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Perceptron
{
    public partial class MainForm : Form
    {
        Network network;
        Hopfield hopfield;
        int inputsCnt = 400;
        int neurCnt = 400;
        int partCnt = 20;
        Boolean draw;
        string picturepath = @"C:\Users\al\Documents\GitHub\PerceptronLetters\1";

        public MainForm()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(pictureBoxInput.Height, pictureBoxInput.Width);
            Graphics g = Graphics.FromImage(bm);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height);
            pictureBoxInput.Image = bm;

        }

        private void openImages_Click(object sender, EventArgs e)
        {
            string[] fullfilesPath = Directory.GetFiles(@".\1");
            ImagesToMatrix I2M = new ImagesToMatrix(partCnt, partCnt);//ourmatrix size hardcode
            I2M.LoadFromFiles(fullfilesPath);
            pictureBoxInput.Image = I2M.GetImages()[0];
            pictureBoxInput.Refresh();
            //debug
            Bitmap bm = new Bitmap(I2M.GetImages()[4].Width, I2M.GetImages()[4].Height);
            for (int i = 0; i < 50; ++i)
            {
                for (int j = 0; j < 50; ++j)
                {
                    if (I2M.GetMatrixarray()[0].matrix[i][j] == 0)
                    {
                        //for (int w = i * bm.Width / 50; w < (i + 1) * bm.Width / 50; ++w)
                        //    for (int h = j * bm.Height / 50; h < (j + 1) * bm.Height / 50; ++h)
                        //        bm.SetPixel(w, h, Color.Black);
                        bm.SetPixel(i * 4, j * 4, Color.Black);
                    }
                }
            }
            pictureBoxInput.Image = bm;
            //end of debug
            pictureBoxInput.Refresh();
        }

        private void TrainNetw_Click(object sender, EventArgs e)
        {
            string[] fullfilesPath = Directory.GetFiles(picturepath);
            ImagesToMatrix I2M = new ImagesToMatrix(partCnt, partCnt);
            I2M.LoadFromFiles(fullfilesPath);
            if (PersBtn.Checked)
            {
                this.network = new Network(inputsCnt, neurCnt);
                network.train(I2M.getOuts(), I2M.getfilenames());
            }
            else
            {
                this.hopfield = new Hopfield(inputsCnt, neurCnt);
                hopfield.train(I2M.getOuts());
            }

        }

        Graphics g;

        private void pictureBoxInput_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            g = Graphics.FromImage(pictureBoxInput.Image);
            g.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 6, 6);
            pictureBoxInput.Refresh();
        }

        private void pictureBoxInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.FillRectangle(new SolidBrush(Color.Black), e.X, e.Y, 6, 6);
                pictureBoxInput.Refresh();
            }
        }

        private void pictureBoxInput_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void Recognize_Click(object sender, EventArgs e)
        {
            if (PersBtn.Checked)
            {
                perceptronRecognize();
            }
            else
            {
                ImagesToMatrix I2M = new ImagesToMatrix(partCnt, partCnt);
                float[] x = I2M.LoadFromImage(pictureBoxInput.Image);
                Matrix.print(x);
                hopfield.recognize(x);
                hopfieldDraw(hopfield.outs);
            }

        }



        private void perceptronRecognize()
        {
            ImagesToMatrix I2M = new ImagesToMatrix(partCnt, partCnt);
            float[] x = I2M.LoadFromImage(pictureBoxInput.Image);
            string str = network.recognize(x);
            pictureBoxOutput.Image = Image.FromFile(str);
            pictureBoxOutput.Refresh();

        }

        private void hopfieldDraw(float[] output)
        {
            Bitmap bm = new Bitmap(200, 200);
            pictureBoxOutput.Image = bm;
            int scaleX = bm.Width / partCnt;
            int scaleY = bm.Height / partCnt;
            Graphics g = Graphics.FromImage(bm);

            for (int i = 0; i < partCnt*partCnt; i++)                
                    if ((int)output[i] == 1)
                    {
                        g.FillRectangle(new SolidBrush(Color.Black),  (i / partCnt)*scaleX, (i % partCnt)*scaleY, scaleX, scaleY);
                    }
            pictureBoxOutput.Refresh();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBoxInput.Image);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBoxInput.Image.Width, pictureBoxInput.Image.Height);
            g.Dispose();
            pictureBoxInput.Refresh();

        }
    }
}
