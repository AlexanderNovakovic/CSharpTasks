using System;
using static System.Math;

namespace Task6_1
{
    public class Cylinder
    {
        public double Radius { get; }
        public double Height { get; }
        public double Volume { get; }

        public Cylinder(double radius, double height)
        {
            if (radius <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }

            double volume = radius * radius * PI * height;

            Radius = radius;
            Height = height;
            Volume = volume;
        }
    }
}
