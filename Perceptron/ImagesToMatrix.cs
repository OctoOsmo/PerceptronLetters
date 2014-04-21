using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Perceptron
{
    class ImagesToMatrix
    {
        string[] fullfilesPath;
        float[][] Input;
        Bitmap bm;
        Image[] img;
        int sizeX;
        int sizeY;
        Matrix[] M;

        public ImagesToMatrix(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.Input = new float[this.sizeX][];
            for (int i = 0; i < this.sizeX; ++i)
                this.Input[i] = new float[this.sizeY];
        }

        public int LoadFromFiles(string[] fullfilesPath)
        {

            this.img = new Image[fullfilesPath.Length];
            this.fullfilesPath = fullfilesPath;
            this.M = new Matrix[fullfilesPath.Length];
            for (int i = 0; i < fullfilesPath.Length; ++i)
            {
                this.img[i] = Image.FromFile(fullfilesPath[i]);
                bm = new Bitmap(img[i]);
                M[i] = new Matrix();
                M[i].BmpToMatrix(bm, this.sizeX, this.sizeY);
            }
            return 0;
        }

        public float[] LoadFromImage(Image image)
        {
            Bitmap bm = new Bitmap(image);
            Matrix m = new Matrix();
            m.BmpToMatrix(bm, this.sizeX, this.sizeY);
            return Matrix.toVector(m);
        }

        public float[][] getOuts()
        {
            float[][] temp = new float[M.Length][];
            for (int i = 0; i < M.Length; i++)
            {
                temp[i] = Matrix.toVector(M[i]);
            }
            return temp;
        }

        public string[] getfilenames()
        {
            return this.fullfilesPath;
        }

        public Image[] GetImages()
        {
            return img;
        }

        public Matrix[] GetMatrixarray()
        {
            return this.M;
        }


    }
}
