using System;
using static System.Math;

namespace Task6_5
{
    public class Triangle : Figure2D
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        private double S => (A + B + C) / 2;
        public override double Perimiter => A + B + C;
        public override double Area => Sqrt(S * (S - A) * (S - B) * (S - C));


        public Triangle(double a, double b, double c, Point center) : 
            base(center)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException();
            }

            A = a;
            B = b;
            C = c;            
        }
    }
}

