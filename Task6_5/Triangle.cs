using System;
using static System.Math;

namespace Task6_5
{
    public class Triangle : IShape
    {
        public double Perimeter { get; }
        public double Area { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException();
            }

            Perimeter = a + b + c;
            double s = Perimeter / 2;
            Area = Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
