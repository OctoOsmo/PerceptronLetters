using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Correspondance
    {
        public string filename;
        public float[] sample;

        public Correspondance(string filename, float[] sample)
        {
            this.filename = filename;
            this.sample = sample;
        }
    }
}
