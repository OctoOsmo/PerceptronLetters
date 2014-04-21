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
        int inputsCnt = 400;
        int neurCnt = 5;
        Boolean draw;

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
            string[] fullfilesPath = Directory.GetFiles(@".\pic");
            ImagesToMatrix I2M = new ImagesToMatrix(50, 50);//ourmatrix size hardcode
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
            string[] fullfilesPath = Directory.GetFiles(@"C:\Users\Svetlana\Documents\Visual Studio 2012\Projects\PerceptronLetters-master\Perceptron\bin\Debug\pic");
            ImagesToMatrix I2M = new ImagesToMatrix(20, 20);//ourmatrix size hardcode
            I2M.LoadFromFiles(fullfilesPath);
            this.network = new Network(inputsCnt, neurCnt);
            network.train(I2M.getOuts(), I2M.getfilenames());
            fullfilesPath = Directory.GetFiles(@"C:\Users\Svetlana\Documents\Visual Studio 2012\Projects\PerceptronLetters-master\Perceptron\bin\Debug\pic1");
            
            I2M.LoadFromFiles(fullfilesPath);
            
            network.train(I2M.getOuts(), I2M.getfilenames());
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
            ImagesToMatrix I2M = new ImagesToMatrix(20, 20);

            float[] x = I2M.LoadFromImage(pictureBoxInput.Image);
            string str = network.recognize(x);
            pictureBoxOutput.Image = Image.FromFile(str);
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
