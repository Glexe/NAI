using System;

namespace MP2.Models
{
    public class Vector
    {
        public double[] Values { get; private set; }

        public double Length => CalculateLength();

        public Vector(double[] values)
        {
            Values = values;
        }

        public double[] Normalized()
        {
            var values = Values;
            for(int i=0; i< values.Length; i++)
            {
                values[i] /= Length;
            }
            return values;
        }

        private double CalculateLength()
        {
            if (Values.Length == 0) return 0;
            double sum = 0;
            foreach(var value in Values)
            {
                sum += Math.Pow(value, 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
