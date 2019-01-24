using System;
using static System.Math;

namespace Task6_5
{
    public class Circle : IShape
    {
        public double Perimeter { get; }
        public double Area { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }

            Perimeter = 2 * radius * PI;
            Area = Pow(radius, 2) * PI;
        }
    }
}
