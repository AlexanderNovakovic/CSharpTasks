using System;
using static System.Math;

namespace Task2_8
{
    public static class MathExtensions
    {
        public static double StandardDeviation(double[] numbers, int n) =>
            Sqrt((SumOfSquares(numbers, n) / n) - Pow(ArithmeticMean(numbers, n), 2));                  
                
        public static double ArithmeticMean(double[] numbers, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }

            return sum / n;
        }

        public static double SumOfSquares(double[] numbers, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += Pow(numbers[i], 2);
            }

            return sum;
        }
    }
}
