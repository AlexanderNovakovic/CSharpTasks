using System;

namespace Task6_1
{
    public class Bucket : Cylinder
    {
        public double Fullness { get; private set; }
        public double RemainingCapacity { get; }

        public Bucket(double radius, double height, double fullness) : base(radius, height)
        {
            if (fullness < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fullness));
            }

            double remainingCapacity = fullness <= Volume ? Volume - fullness : 0;

            Fullness = fullness <= Volume ? fullness : Volume;
            RemainingCapacity = remainingCapacity;
        }

        public bool IsFull() =>
            Fullness == Volume;

        public bool IsEmpty() =>
            Fullness == 0;

        public void PourIn(double quantity)
        {
            if (Fullness + quantity <= Volume)
            {
                 Fullness += quantity;
            }
            else
            {
                Fullness = Volume;
            }
        }

        public void PourOut(double quantity)
        {
            if (Fullness - quantity >= 0)
            {
                Fullness -= quantity;                
            }
            else
            {
                Fullness = 0;
            }
        }

        public void PourFrom(Bucket other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            if (RemainingCapacity >= other.Fullness)
            {
                Fullness += other.Fullness;
                other.Fullness = 0;
            }
            else
            {
                Fullness = Volume;
                other.Fullness -= RemainingCapacity;
            }
        }
    }
}
