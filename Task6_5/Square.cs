using System;

namespace Task6_5
{
    public class Square : IShape
    {
        public double Perimeter { get; }
        public double Area { get; }

        public Square(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            Perimeter = 4 * a;
            Area = a * a;
        }
    }
}
