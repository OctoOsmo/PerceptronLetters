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
        public float[][] matrix;
        public Matrix()
        {
            //this.matrix = matrix;
        }

        public Matrix(int sizeX, int sizeY)
        {
            this.matrix = new float[sizeX][];
            for (int i = 0; i < sizeX; ++i)
                this.matrix[i] = new float[sizeY];
        }

        public void setValues(float[][] matrix)
        {
            this.matrix = matrix;
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

        public static float[] mult(float[] x, Matrix A)
        {
            float s;
            int maxY = A.matrix[0].Length;
            float[] temp = new float[maxY];
            for (int i = 0; i < maxY; ++i)
            {
                s = 0;
                for (int j = 0; j < A.matrix.GetLength(0); ++j)
                {
                    s += x[j] * A.matrix[j][i];
                }
                temp[i] = s;
            }
            return temp;
        }

        public static float[] toVector(Matrix A)
        {
            int n = 0;
           int  x = A.matrix.GetLength(0);
           int y = A.matrix[0].Length; 
            float[] temp = new float[x*y];
            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    temp[n] = A.matrix[i][j];
                    n++;
                }
            }
            return temp;
        }

        public static float[] add(float[] x, float[] y, char sign)
        {
            float[] temp = new float[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                if (sign == '+')
                    temp[i] = x[i] + y[i];
                else if (sign == '-')
                    temp[i] = x[i] - y[i];
            }
            return temp;
        }

        public static float distance(float[] x, float[] y)
        {
            float s = 0;
            for (int i = 0; i < x.Length; i++ )
            {
                s += x[i] * y[i];
            }
            s = (float)Math.Sqrt(Math.Abs(s));
            return s;
        }

    }
}
