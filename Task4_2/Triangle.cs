using System;
using static System.Math;

namespace Task4_2
{
    public class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Circumference { get; }
        public double Area { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentOutOfRangeException("Invalid input.");
            
            double circumference = a + b + c;
            double s = circumference / 2;
            double area = Sqrt(s * (s - a) * (s - b) * (s - c));

            A = a;
            B = b;
            C = c;
            Circumference = circumference;
            Area = area;
        }
    }
}
