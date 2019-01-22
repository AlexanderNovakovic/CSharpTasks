using System;
using static System.Math;

namespace Task6_1
{
    public class Bucket : Cylinder
    {
        public double VolumeFilled { get; private set; }
        public double RemainingCapacity => Volume - VolumeFilled;
        public bool IsFull => VolumeFilled == Volume;
        public bool IsEmpty => VolumeFilled == 0;

        public Bucket(double radius, double height, double volumeFilled) : base(radius, height)
        {
            if (volumeFilled < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(volumeFilled));
            }

            VolumeFilled = Min(volumeFilled, Volume);
        }

        public void PourIn(double quantity) => 
            VolumeFilled = Min(VolumeFilled + quantity, Volume);

        public void PourOut(double quantity) =>
            VolumeFilled = Max(VolumeFilled - quantity, 0);

        public void PourFrom(Bucket other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            double remainingCapacity = RemainingCapacity;

            PourIn(other.VolumeFilled);
            other.PourOut(remainingCapacity);
        }
    }
}
