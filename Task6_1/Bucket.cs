using System;

namespace Task6_1
{
    public class Bucket : Cylinder
    {
        public double Fillness { get; private set; }
        public double RemainingCapacity { get; }

        public Bucket(double radius, double height, double fillness) : base(radius, height)
        {
            if (fillness < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fillness));
            }

            double remainingCapacity = fillness <= Volume ? Volume - fillness : 0;

            Fillness = fillness <= Volume ? fillness : Volume;
            RemainingCapacity = remainingCapacity;
        }

        public bool IsFull() =>
            Fillness == Volume;

        public bool IsEmpty() =>
            Fillness == 0;

        public void PourIn(double quantity)
        {
            if (Fillness + quantity <= Volume)
            {
                 Fillness += quantity;
            }
            else
            {
                Fillness = Volume;
            }
        }

        public void PourOut(double quantity)
        {
            if (Fillness - quantity >= 0)
            {
                Fillness -= quantity;                
            }
            else
            {
                Fillness = 0;
            }
        }

        public void PourFrom(Bucket other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            if (RemainingCapacity >= other.Fillness)
            {
                Fillness += other.Fillness;
                other.Fillness = 0;
            }
            else
            {
                Fillness = Volume;
                other.Fillness -= RemainingCapacity;
            }
        }
    }
}
