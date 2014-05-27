using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Perceptron
{
    class Hopfield
    {
        Matrix weights;
        int inputSize;
        int neurCnt;
        int maxIter = 100000;
        float trainSpeed = 0.5f;
        public float[] outs;

        public Hopfield(int inputsize, int neurCnt)
        {
            this.inputSize = inputsize;
            this.neurCnt = neurCnt;
            this.weights = new Matrix(inputSize, neurCnt);
        }

        public void loadWeights(string filename)
        {
            float[][] z = new float[inputSize][];
            for (int i = 0; i < inputSize; i++)
                z[i] = new float[neurCnt];
            String st;
            string[] x = new string[neurCnt];
            StreamReader sr = File.OpenText(filename);
            for (int i = 0; i < inputSize; i++)
            {
                st = sr.ReadLine();
                if (st != null)
                {
                    x = st.Split(' ');
                    for (int j = 0; j < neurCnt; j++)
                        z[i][j] = (float)Convert.ToDouble(x[j]);
                }
            }
            sr.Close();
            this.weights.setValues(z);
        }

        public void saveWeights(string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputSize; i++)
            {
                for (int j = 0; j < neurCnt; j++)
                {
                    sb.Append(weights.matrix[i][j] + ' ');
                }
                sb.Append("\n");
            }
            sw.Write(sb.ToString());
        }

        public void resetWeights()
        {
            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < neurCnt; j++)
                    weights.matrix[i][j] = 0;
        }

        public void initWeights()
        {
            Random r = new Random();
            for (int i = 0; i < inputSize; i++)
            {
                weights.matrix[i][i] = 0;
            }
        }

        int func(int number, float[] input)
        {
            float sum = 0;
            for (int i = 0; i < inputSize; i++)
            {
                sum = sum + input[i] * weights.matrix[i][number];
            }
            if (sum > -0.001 && sum < 0.001) {return (int)input[number];}
            else
            if (sum > 0) { return (1); }
            else
             { return (-1); }
            
        }

        public void train(float[][] samples)
        {
            initWeights();
            correctWeights(samples);
            float[] z = new float[inputSize];
            for (int i = 0; i < inputSize; i++)
                z[i] = samples[0][i];
            Console.WriteLine("Input");
            Matrix.print(z);
        }

        public void recognize(float[] input)
        {
            this.outs = new float[inputSize];
            float[] z = Matrix.copy(input);
            float[] y = new float[inputSize];
            do
            {
                y = Matrix.copy(z);
                for (int i = 0; i < inputSize; i++)
                {
                    z[i] = func(i, z);
                    if (z[i] > 0.999) outs[i] = 1;
                    else outs[i] = 0;
                }                
            }
            while (!Matrix.compare(z, y));
            Matrix.print(outs);
        }

        private void correctWeights(float[][] input)
        {
            float s;
            for (int i = 0; i < inputSize; i++)
            {
                for (int j = 0; j < inputSize; j++)
                {
                    if (i == j) weights.matrix[i][j] = 0;
                    else
                    {
                        s = 0;
                        for (int k = 0; k < input.GetLength(0); k++)
                            s += input[k][i] * input[k][j];
                        weights.matrix[i][j] = s;
                    }
                }
            }
            Console.WriteLine("weights");
            Matrix.print(weights);

            for (int i = 0; i < inputSize; i++)
            {
                if (weights.matrix[i][i] > 0.001 || weights.matrix[i][i] < -0.001)
                {
                    //MessageBox.Show("mismatch!" + ' ' + i.ToString() + ' ' + weights.matrix[i][i].ToString());
                    //break;
                }
                for (int j = 0; j < i; ++j)
                    if (weights.matrix[i][j] != weights.matrix[j][i])
                    {
                        Console.Write("mismatch!");
                        MessageBox.Show("mismatch!");
                        break;
                    }
            }
        }

        
    }
}
