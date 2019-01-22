using Xunit;

namespace Task6_3.UnitTests
{
    public class VehicleTests
    {
        [Theory]
        [InlineData(4, 1200, 1500, new double[] { 55, 65, 75, 85 })]
        [InlineData(3, 1200, 1500, new double[] { 100, 100, 100 })]
        [InlineData(5, 1200, 1500, new double[] { 75, 35, 45, 65, 20 })]
        public void AddPassengersTests(int passengersCapacity, double vehicleWeight, double maxWeight, double[] passengerWeights)
        {
            Vehicle vehicle = new Vehicle(vehicleWeight, maxWeight, passengersCapacity);

            foreach (double passengerWeight in passengerWeights)
            {
                vehicle.AddPassenger(passengerWeight);
            }

            Assert.True(vehicle.TotalWeight <= maxWeight);
        }

        [Theory]
        [InlineData(1200, 1500, new double[] { 55, 65, 75, 85 })]
        [InlineData(1200, 1500, new double[] { 100, 100, 100 })]
        [InlineData(1200, 1500, new double[] { 75, 35, 45, 65, 20 })]
        public void AddLoadTests(double vehicleWeight, double maxWeight, double[] loads)
        {
            Vehicle vehicle = new Vehicle(vehicleWeight, maxWeight, 2);

            foreach (double load in loads)
            {
                vehicle.AddLoad(load);
            }

            Assert.True(vehicle.TotalWeight <= maxWeight);
        }
    }
}
