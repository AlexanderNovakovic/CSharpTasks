using System;
using System.Security.Cryptography.X509Certificates;

namespace Task5_1
{
    public class Circle : IEquatable<Circle>
    {
        public Point Center { get; }
        public double R { get; }

        public Circle(Point center, double r)
        {
            if (r <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(r));
            }

            Center = center ?? throw new ArgumentNullException(nameof(center));
            R = r;
        }

        public bool IsOverlapping(Circle other) =>
            Center.Distance(other.Center) < R + other.R;

        public Circle Move(double dx, double dy) => 
            new Circle(Center.Move(dx, dy), R);

        public Circle Move(Point point) => 
            new Circle(point, R);

        public bool Equals(Circle other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Center == other.Center && R == other.R;
        }

        public override bool Equals(object obj) => 
            Equals(obj as Circle);

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Center != null ? Center.GetHashCode() : 0) * 397) ^ R.GetHashCode();
            }
        }
    }
}
