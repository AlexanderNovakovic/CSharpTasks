using Xunit;

namespace Task6_3.UnitTests
{
    public class TruckTests
    {
        [Theory]
        [InlineData(1200, 1500, new double[] { 55, 65, 75, 85 })]
        [InlineData(1200, 1500, new double[] { 100, 100, 100 })]
        [InlineData(1200, 1500, new double[] { 75, 35, 45, 65, 20 })]
        public void AddPersonsTest(double weight, double maxWeight, double[] loadWeights)
        {
            Truck truck = new Truck(weight, maxWeight);

            foreach (double passangerWeight in loadWeights)
            {
                truck.AddWeight(passangerWeight);
            }

            Assert.True(truck.Weight <= maxWeight);
        }
    }
}
