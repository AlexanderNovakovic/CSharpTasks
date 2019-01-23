using System;

namespace Task6_4
{
    public class RectangularPrism : IShape
    {
        public double Volume { get; }

        public RectangularPrism(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException();
            }

            Volume = a * b * c;
        }
    }
}
