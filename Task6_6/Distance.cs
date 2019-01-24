using System;
using static System.Math;

namespace Task6_6
{
    public class Distance : Line
    {
        public Point A { get; }
        public Point B { get; }

        public override double Length => Sqrt(Pow(A.X - B.X, 2) + Pow(A.Y - B.Y, 2));

        public Distance(Point a, Point b)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
        }
    }
}
