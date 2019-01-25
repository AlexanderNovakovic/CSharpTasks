using System;
using System.Diagnostics.CodeAnalysis;

namespace Task6_6
{
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    public class Polyline : ILine
    {
        public Point[] Points { get; }
        public Distance[] Lines { get; }
        public double Length { get; }

        public Polyline(Point[] points)
        {
            Points = points ?? throw new ArgumentNullException(nameof(points));
            Lines = new Distance[Points.Length];
            Length = 0;

            for (int i = 0; i < Points.Length - 1; i++)
            {
                Lines[i] = new Distance(Points[i], Points[i + 1]);
                Length += Lines[i].Length;
            }
        }
    }
}
