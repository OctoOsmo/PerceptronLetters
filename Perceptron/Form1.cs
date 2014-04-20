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
            string[] fullfilesPath = Directory.GetFiles(@"C:\Users\Svetlana\Documents\Visual Studio 2012\Projects\PerceptronLetters-master\Perceptron\bin\Debug\pic");
            ImagesToMatrix I2M = new ImagesToMatrix(50, 50);//ourmatrix size hardcode
            I2M.LoadFromFiles(fullfilesPath);
            pictureBoxInput.Image = I2M.GetImages()[0];
            pictureBoxInput.Refresh();
            //debug
            Bitmap bm = new Bitmap(50, 50);
            for (int i = 0; i < 50; ++i)
                for (int j = 0; j < 50; ++j)
                {
                    if (I2M.GetMatrixarray()[0].matrix[i][j] == 1)
                        bm.SetPixel(i, j, Color.Black);
                }
            pictureBoxInput.Image = bm;
            //debug
            pictureBoxInput.Refresh();
        }
    }
}
