using System;
using static System.Math;

namespace Task6_4
{
    public class Sphere : IShape
    {
        public double Volume { get; }

        public Sphere(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }

            Volume = 4.0 / 3 * Pow(radius, 3) * PI;
        }
    }
}
