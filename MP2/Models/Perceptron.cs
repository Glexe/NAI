using System;

namespace MP2.Models
{
    public class Perceptron
    {
        public double[] Weights { get; set; }
        public float Threshold { get; set; }

        public void ResizeWeights(int size, bool fillWithRandomValues = true)
        {
            if (size <= 0) throw new ArgumentException("Weights count cant be negative");
            Weights = new double[size];
            if (fillWithRandomValues)
            {
                for (int i = 0; i < Weights.Length; i++)
                    Weights[i] = new Random().NextDouble();
            }
        }

        public int GetOutput(double[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += Weights[i] * input[i];
            }

            return sum > Threshold ? 1 : 0;
        }
    }
}
