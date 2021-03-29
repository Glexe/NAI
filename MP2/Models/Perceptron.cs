using System;

namespace MP2.Models
{
    public class Perceptron
    {
        public double[] Weights { get; set; }
        public float Threshold { get; set; }

        public Perceptron(double[] weights,  float threshold)
        {
            Weights = weights;
            Threshold = threshold;
        }

        public Perceptron(float threshold)
        {
            Threshold = threshold;
        }

        public Perceptron()
        {

        }

        public void ResizeWeights(int size, bool fillWithRandomValues = true)
        {
            if (size <= 0) throw new ArgumentException("Weights count cant be negative");
            Weights = new double[size];
            if (fillWithRandomValues)
            {
                for (int i = 0; i < Weights.Length; i++) 
                    Weights[i] = new Random().Next(0, 1);
            }
        }

        public int GetOutput(double[] input)
        {
            double sum = 0;
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sum += Weights[i] * input[i];
                }
            }
            catch
            {
                return -1;
            }

            return sum > Threshold ? 1 : 0;
        }
    }
}
