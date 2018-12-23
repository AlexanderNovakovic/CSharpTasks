using System;

namespace Task3_1
{
    public static class DoubleExtensions
    {
        public static double Sum(double[] numbers, double x, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double p = numbers[n];

            for (int i = n - 1; i >= 0; i--)
            {
                p = p * x + numbers[i];
            }

            return p;
        }
    }
}
