using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Perceptron
{

    class Matrix
    {
        float[][] matrix;
        public Matrix()
        {
            //this.matrix = matrix;
        }

        public Matrix BmpToMatrix(Bitmap bm, int sizeX, int sizeY)
        {

            float[][] Input = new float[sizeX][];
            for (int i = 0; i < sizeX; ++i)
                Input[i] = new float[sizeY];
            Matrix m = new Matrix();
            for (int i = 0; i < bm.Width; ++i)
                for (int j = 0; j < bm.Height; ++j)
                    if (bm.GetPixel(i, j).ToArgb() == Color.Black.ToArgb())
                        Input[i / sizeX][j / sizeY] = 1;
            this.matrix = Input;
            return m;
        }

    }
}
