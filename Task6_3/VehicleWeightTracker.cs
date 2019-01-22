using System;

namespace Task6_3
{
    internal class VehicleWeightTracker
    {
        public double VehicleWeight { get; }
        public double TotalWeight { get; private set; }
        public double MaxWeight { get; }

        public VehicleWeightTracker(double vehicleWeight, double maxWeight)
        {
            if (vehicleWeight <= 0 || maxWeight <= 0 || vehicleWeight > maxWeight)
            {
                throw new ArgumentException();
            }

            VehicleWeight = vehicleWeight;
            TotalWeight = VehicleWeight;
            MaxWeight = maxWeight;
        }

        public void AddWeight(double weight)
        {
            if (weight <= 0 || TotalWeight + weight > MaxWeight)
            {
                throw new ArgumentException();
            }

            TotalWeight += weight;
        }
    }
}
