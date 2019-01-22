using System;

namespace Task6_4
{
    public class RectangularPrism : Object, IEquatable<RectangularPrism>
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public override double Volume => A * B * C;

        public RectangularPrism(double sigma, double a, double b, double c) 
            : base(sigma)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw  new ArgumentException();
            }

            A = a;
            B = b;
            C = c;
        }

        public bool Equals(RectangularPrism other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return A == other.A && B == other.B && C == other.C && Sigma == other.Sigma;
        }

        public override bool Equals(object obj) =>
            Equals(obj as RectangularPrism);

        public override int GetHashCode()
        {
            unchecked
            {
                return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ Sigma.GetHashCode();
            }
        }
    }
}
