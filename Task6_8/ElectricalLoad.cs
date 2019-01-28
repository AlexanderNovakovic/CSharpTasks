using System;

namespace Task6_8
{
    public abstract class ElectricalLoad : IEquatable<ElectricalLoad>
    {
        public abstract double Power { get; }

        public bool Equals(ElectricalLoad other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Power == other.Power;
        }

        public override bool Equals(object obj) =>
            Equals(obj as ElectricalLoad);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Power.GetHashCode() * 397);
            }
        }
    }
}

