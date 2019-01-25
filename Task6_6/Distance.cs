using System;
using static System.Math;

namespace Task6_6
{
    public class Distance : ILine
    {
        public Point A { get; }
        public Point B { get; }
        public double Length { get; }

        public Distance(Point a, Point b)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));

            if (A.Equals(B))
            {
                throw new ArgumentException();
            }

            Length = Sqrt(Pow(A.X - B.X, 2) + Pow(A.Y - B.Y, 2));
        }
    }
}
