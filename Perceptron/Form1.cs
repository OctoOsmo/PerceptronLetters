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
            string[] fullfilesPath = Directory.GetFiles(@"C:\Users\al\Documents\GitHub\NeurNetw\NeurNetw\bin\Debug\pic");
            ImagesToMatrix I2M = new ImagesToMatrix(50, 50);//ourmatrix size hardcode
            I2M.LoadFromFiles(fullfilesPath);
            pictureBoxInput.Image = I2M.GetImages()[0];
            pictureBoxInput.Refresh();
            //debug
            //Bitmap bm = new Bitmap(50, 50);
            //pictureBoxInput.
            Graphics g = Graphics.FromImage(pictureBoxInput.Image);
            for (int i = 0; i < 50; ++i)
                for (int j = 0; j < 50; ++j)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), i, j, 1, 1);
                }
            //debug            
            pictureBoxInput.Refresh();
        }
    }
}
