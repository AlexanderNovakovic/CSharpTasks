using System;
using static System.Math;

namespace Task2_7
{
    public static class DoubleExtensions
    {
        public static double SumOfPowers1(this double x, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Pow(x, i);
            }

            return sum;
        }

        public static double SumOfPowers2(this double x, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Pow(-1, i - 1) * Pow(x, i);
            }

            return sum;
        }
    }
}
