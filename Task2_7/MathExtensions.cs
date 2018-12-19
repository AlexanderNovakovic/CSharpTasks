using System;
using System.Collections.Generic;
using static System.Math;

namespace Task2_7
{
    public static class MathExtensions
    {
        public static double[] SumTwo(Equation equation, int n)
        {
            List<double> result = new List<double>();

            for (double x = equation.XMin; x <= equation.XMax; x += equation.DX)
            {
                double sum = SumOfSquaresTwo(x, n);
                result.Add(sum);
            }

            return result.ToArray();
        }

        public static double[] Sum(Equation equation, int n)
        {            
            List<double> result = new List<double>();
            
            for (double x = equation.XMin; x <= equation.XMax; x += equation.DX)
            {
                double sum = SumOfSquares(x, n);
                result.Add(sum);
            }

            return result.ToArray();
        }

        public static double SumOfSquaresTwo(double x, int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
                sum += Pow(-1, i - 1) * Pow(x, i);

            return sum;
        }

        public static double SumOfSquares(double x, int n)
        {
            Validate(n);

            double sum = 0;

            for (int i = 1; i <= n; i++)
                sum += Pow(x, i);

            return sum;
        }

        public static void Validate(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n));
        }
    }
}
