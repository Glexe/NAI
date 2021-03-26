using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2.Models
{
    class Perceptron
    {
        private double[] _weights;
        private float _learningRate; 
        private float _threshold;

        public void Train(double[][] inputData, double[] outputs, float threshold, float learningRate, int epoch)
        {
            _threshold = threshold;
            _learningRate = learningRate;
        }
    }
}
