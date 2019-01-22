using Xunit;

namespace Task6_3.UnitTests
{
    public class VehicleWeightTrackerTests
    {
        [Theory]
        [InlineData(1200, 1500, new double[] { 55, 65, 75, 85 })]
        [InlineData(1200, 1500, new double[] { 100, 100, 100 })]
        [InlineData(1200, 1500, new double[] { 75, 35, 45, 65, 20 })]
        public void AddWeightTests(double vehicleWeight, double maxWeight, double[] loads)
        {
            VehicleWeightTracker tracker = new VehicleWeightTracker(vehicleWeight, maxWeight);

            foreach (double load in loads)
            {
                tracker.AddWeight(load);
            }

            Assert.True(tracker.TotalWeight <= tracker.MaxWeight);
        }
    }
}
