namespace Task6_3
{
    public class Vehicle
    {
        private VehicleWeightTracker VehicleWeightTracker { get; }
        private PassengerTracker PassengerTracker { get; }

        public double TotalWeight => VehicleWeightTracker.TotalWeight;

        public Vehicle(double vehicleWeight, double maxWeight, int passengersCapacity)
        {
            VehicleWeightTracker = new VehicleWeightTracker(vehicleWeight, maxWeight);
            PassengerTracker = new PassengerTracker(passengersCapacity);
        }

        public void AddPassenger(double passengerWeight)
        {
            VehicleWeightTracker.AddWeight(passengerWeight);
            PassengerTracker.AddPassenger();
        }

        public void AddLoad(double load) =>
            VehicleWeightTracker.AddWeight(load);
    }
}
