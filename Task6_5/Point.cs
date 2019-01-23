using System;

namespace Task6_5
{
    public class Point : IEquatable<Point>
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point MoveTo(double dx, double dy) => 
            new Point(X + dx, Y + dy);

        public bool Equals(Point other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Point);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397);
                return hashCode;
            }
        }
    }
}
