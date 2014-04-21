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
        public MainForm()
        {
            InitializeComponent();
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
                    if (I2M.GetMatrixarray()[0].matrix[i][j] == 1)
                    {
                        //for (int w = i * bm.Width / 50; w < (i + 1) * bm.Width / 50; ++w)
                        //    for (int h = j * bm.Height / 50; h < (j + 1) * bm.Height / 50; ++h)
                                //bm.SetPixel(w, h, Color.Black);
                        bm.SetPixel(i, j, Color.Black);
                    }
                }
            }
            pictureBoxInput.Image = bm;
            //end of debug
            pictureBoxInput.Refresh();
        }
    }
}
