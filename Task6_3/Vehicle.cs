using System;

namespace Task6_3
{
    public class Vehicle
    {
        public double Weight { get; private set; }
        public double MaxWeight { get; set; }

        public Vehicle(double weight, double maxWeight)
        {
            if (weight > maxWeight)
            {
                throw new ArgumentException();
            }

            Weight = weight;
            MaxWeight = maxWeight;
        }

        public virtual void AddWeight(double additionalWeight)
        {
            if (additionalWeight < 0 || Weight + additionalWeight > MaxWeight)
            {
                throw new ArgumentException();
            }

            Weight += additionalWeight;
        }
    }
}
