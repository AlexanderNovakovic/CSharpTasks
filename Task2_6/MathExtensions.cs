using System;

namespace Task2_6
{
    public static class MathExtensions
    {
        public static double SumOfNNumbers(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            return sum;
        }

        public static double SumOfNFactoralsDevidedByFractions(int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += NFactorial(i) / SumOfFractions(i);
            }

            return sum;
        }

        public static double SumOfFractions(int i)
        {
            Validate(i);

            double sum = 0;

            for (int j = 1; j <= i; j++)
            {
                sum += 1.0 / (j + 1);
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

        public static long NFactorial(int n)
        {
            Validate(n);

            long result = 1;

            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }



        public static void Validate(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n));
        }
    }
}
