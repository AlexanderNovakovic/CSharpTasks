using System;
using static System.Math;

namespace Task2_9
{
    public static class MathExtensions
    {
        public static double SumAscending(int n)
        {
            if (n <= 0)
            { 
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / Pow(i, 2);
            }

            return sum;
        }

        public static double SumDescending(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double sum = 0;

            for (int i = n; i > 0; i--)
            {
                sum += 1.0 / Pow(i, 2);
            }

            return sum;    
        }
    }
}
