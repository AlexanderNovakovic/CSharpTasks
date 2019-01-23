using System;

namespace Task6_5
{
    public class Square : Figure2D
    {
        public double A { get; }

        public override double Perimiter => 4 * A;
        public override double Area => A * A;

        public Square(double a, Point center) : base(center)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            A = a;
        }
    }
}
