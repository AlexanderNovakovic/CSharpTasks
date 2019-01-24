using System;

namespace Task6_4
{
    public class Figure3D : IEquatable<Figure3D>
    {
        private IShape Shape { get; }

        public double Sigma { get; }
        public double Mass => Volume * Sigma;
        public double Volume => Shape.Volume;

        public Figure3D(double sigma, IShape shape)
        {
            if (sigma < 0)
            {
                throw new ArgumentException();
            }

            Sigma = sigma;
            Shape = shape ?? throw new ArgumentNullException(nameof(shape));
        }

        public bool Equals(Figure3D other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Sigma == other.Sigma 
                   && Mass == other.Mass 
                   && Volume == other.Volume;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Figure3D);

        public override int GetHashCode()
        {
            return Sigma.GetHashCode() ^ Mass.GetHashCode() ^ Volume.GetHashCode();
        }
    }
}
