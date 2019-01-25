using System;

namespace Task6_6
{
    public class Polygon : ILine
    {
        public Point[] Points { get; }
        public Distance[] Lines { get; }
        public double Length { get; }

        public Polygon(Point[] points)
        {
            Points = points ?? throw new ArgumentNullException(nameof(points));
            Lines = new Distance[Points.Length + 1];
            Length = 0;

            for (int i = 0; i < Points.Length - 1; i++)
            {
                Lines[i] = new Distance(Points[i], Points[i + 1]);
                Length += Lines[i].Length;
            }

            Lines[Lines.Length - 1] = new Distance(Points[Points.Length - 1], Points[0]);
            Length += Lines[Lines.Length - 1].Length;
        }
    }
}
