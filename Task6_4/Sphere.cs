using System;
using static System.Math;

namespace Task6_4
{
    public class Sphere : Object, IEquatable<Sphere>
    {
        public double Radius { get; }

        public override double Volume => 4.0 / 3 * Pow(Radius, 3) * PI;

        public Sphere(double sigma, double radius) : base(sigma)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }

            Radius = radius;
        }
        public bool Equals(Sphere other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Radius == other.Radius && Sigma == other.Sigma;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Sphere);

        public override int GetHashCode()
        {
            unchecked
            {
                return Radius.GetHashCode() ^ Sigma.GetHashCode();
            }
        }
    }
}
