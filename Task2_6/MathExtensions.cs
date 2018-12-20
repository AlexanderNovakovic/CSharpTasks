using System;
using static System.Math;

namespace Task2_6
{
    public static class MathExtensions
    {
        public static double FinalSum(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Pow(-1, i - 1) * SumOfNNumbers(i) / SumOfSqares(i);
            }

            return sum;
        }

        public static double SumOfNFactorialsDividedByFractions(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += NFactorial(i) / SumOfFractions(i);
            }

            return sum;
        }

        public static double SumOfFractions(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i + 1);
            }

            return sum;
        }

        public static long SumOfNFactorials(int n)
        {
            Validate(n);

            long sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += NFactorial(i);
            }            

            return sum;
        }

        public static double SumOfSqares(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        public static double SumOfNNumbers(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static long NFactorial(int n)
        {
            Validate(n);

            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static void Validate(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
        }
    }
}
