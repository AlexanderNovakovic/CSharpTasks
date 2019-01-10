using System;
using static System.Math;

namespace Task5_1
{
    public class Point : IEquatable<Point>
    {
        public double X { get; }
        public double Y { get; }
        public double DistanceFromOrigin { get; }

        public Point() : this(0, 0)
        {
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;

            double distanceFromOrigin = Sqrt(Pow(x, 2) + Pow(y, 2));
            DistanceFromOrigin = distanceFromOrigin;
        }

        public double Distance(Point point) => 
            Sqrt(Pow(X - point.X, 2) + Pow(Y - point.Y, 2));

        public Point Move(double dx, double dy) =>
            new Point(X + dx, Y + dy);

        public static bool operator ==(Point left, Point right) =>
            !(left is null ^ right is null) && (left is null || left.Equals(right));

        public static bool operator !=(Point left, Point right) =>
            !(left == right);

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

            return X == other.X 
                && Y == other.Y 
                && DistanceFromOrigin == other.DistanceFromOrigin;
        }

        public override bool Equals(object obj) => 
            Equals(obj as Point);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ DistanceFromOrigin.GetHashCode();
                return hashCode;
            }
        }
    }
}
