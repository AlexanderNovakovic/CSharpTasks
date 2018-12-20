using System;
using System.Linq;

namespace Task2._1
{
    public static class MathExtensions
    {
        public static double Min(double a, double b, double c)
        {
            if (a < b && a < c)
                return a;

            if (b < a && b < c)
                return b;

            return c;
        }

        public static double Min2(double a, double b, double c) =>
            Math.Min(a, Math.Min(b, c));

        public static double Min3(params double[] numbers)
        {
            double min = double.MinValue;

            foreach (double number in numbers)
            {
                if (number < min)
                    min = number;
            }

            return min;
        }

        public static double Min4(params double[] numbers) =>
            numbers.Min();
    }
}
