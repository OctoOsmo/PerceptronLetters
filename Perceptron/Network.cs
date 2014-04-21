using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace Perceptron
{
    class Network
    {
        Matrix weights;
        float trainSpeed = 1;
        int inputSize;
        int neurCnt;
        List<Correspondance> correspondances;
        int maxIter = 2;

        public Network(int inputSize, int neurCnt)
        {
            this.inputSize = inputSize;
            this.neurCnt = neurCnt;
            this.weights = new Matrix(inputSize, neurCnt);
            this.correspondances = new List<Correspondance>();
        }

        public void setTrainSpeed(float speed)
        {
            this.trainSpeed = speed;
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

        public float[][] loadOutputs(string filename, int samplesCnt)
        {
            float[][] z = new float[samplesCnt][];
            for (int i = 0; i < samplesCnt; i++)
                z[i] = new float[neurCnt];
            String st;
            string[] x = new string[neurCnt];
            StreamReader sr = File.OpenText(filename);
            for (int i = 0; i < samplesCnt; i++)
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
            return z;
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

        //delta-rule
        private void correctWeights(float[] err, float[] input)
        {
            float[][] z = new float[inputSize][];
            for (int i = 0; i < inputSize; i++)
                z[i] = new float[neurCnt];
            for (int i = 0; i < inputSize; i++)
            {
                for (int j = 0; j < neurCnt; j++)
                {
                    z[i][j] = z[i][j] + trainSpeed*err[j]*input[i];
                }
            }

            this.weights.setValues(z);
        }

        public void resetWeights()
        {
            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < neurCnt; j++)
                    weights.matrix[i][j] = 0;
        }

        float[] porog(float[] net)
        {
            float[] temp = new float[net.Length];
            for (int i = 0; i < net.Length; i++)
            {
                if (net[i] >= 0) temp[i] = 1;
                else temp[i] = 0;
            }
            return temp;
        }

        public string getSampleName(float[] sample)
        {
            Predicate<Correspondance> pr = c => c.sample.SequenceEqual(sample);
            return correspondances.Find(pr).filename;
        }


        public void train(float[][] samples, string[] filenames) // samples : float[samplesCnt][inputsCnt]
        {
            float[][] outputs = this.loadOutputs("outs.txt", 4);  //Attention: hardcode!
            float[] output = new float[neurCnt];
            float[] err = new float[neurCnt];
            double eps = 0.00001;
            Boolean complete = false;
            int changesCnt;
            int n = 0;
            while ((!complete))
            {
                changesCnt = 0;
                correspondances.Clear();
                for (int i = 0; i < samples.GetLength(0); i++)
                {
                    output = porog(Matrix.mult(samples[i], weights));
                    err = Matrix.add(outputs[i], output, '-');
                    if (Matrix.distance(err, err) > eps)
                    {
                        this.correctWeights(err, samples[i]);
                        changesCnt++;
                        if (n == maxIter) correspondances.Add(new Correspondance(filenames[i], output));
                    }
                    else
                    {
                        correspondances.Add(new Correspondance(filenames[i], output));
                    }
                }
                n++;
                complete = (changesCnt == 0)||(n > maxIter);
            }
        }

        public string recognize(float[] input)
        {
            float[] outp = new float[neurCnt];
            outp = porog(Matrix.mult(input, weights));
            return getSampleName(outp);
        }

        float[] porog(float[] net)
        {
            float[] temp = new float[net.Length];
            for (int i = 0; i < net.Length; i++)
            {
                if (net[i] >= 0) temp[i] = 1;
                else temp[i] = 0;
            }
            return temp;
        }
    }
}
