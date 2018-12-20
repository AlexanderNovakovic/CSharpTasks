using System;
using static System.Math;

namespace Task4
{
    public class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        private static void ValidateSides(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException(nameof(a));

            if (b <= 0)
                throw new ArgumentException(nameof(b));

            if (c <= 0)
                throw new ArgumentException(nameof(c));

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException();
        }

        public static double CalculateSide(double x1, double x2, double y1, double y2) =>
            Sqrt(Pow(x1 - x2, 2) + Pow(y1 - y2, 2));

        public double Area()
        {
            double s = (A + B + C) / 2;

            return Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}
