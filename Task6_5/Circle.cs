using System;
using static System.Math;

namespace Task6_5
{
    public class Circle : Figure2D
    {
        public double Radius { get; }

        public override double Perimiter => 2 * Radius * PI;
        public override double Area => Pow(Radius, 2) * PI;

        public Circle(double radius, Point center) : base(center)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }

            Radius = radius;            
        }
    }
}
