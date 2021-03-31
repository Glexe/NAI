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

        public int GetOutput(Vector vector)
        {
            double sum = 0;
            var inputVector = vector.Normalized();
            for (int i = 0; i < inputVector.Length; i++)
            {
                sum += Weights[i] * inputVector[i];
            }

            return sum > Threshold ? 1 : 0;
        }
    }
}
