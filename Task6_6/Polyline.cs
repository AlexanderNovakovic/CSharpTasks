using System;

namespace Task6_6
{
    public class Polyline : Line
    {
        public Point[] Points { get; }

        public override double Length
        {
            get
            {
                double length = 0;

                for (int i = 0; i < Points.Length - 1; i++)
                {
                    length += new Distance(Points[i], Points[i + 1]).Length;
                }

                return length;
            }
        }

        public Polyline(Point[] points)
        {
            Points = points ?? throw new ArgumentNullException(nameof(points));
        }
    }
}
