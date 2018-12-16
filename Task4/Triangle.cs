using System;

namespace Task4
{
    public class Triangle
    {
        public double CalculateSide(double x1, double x2, double y1, double y2) =>
            Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        public double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
