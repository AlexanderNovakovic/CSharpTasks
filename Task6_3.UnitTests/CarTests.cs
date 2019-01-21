using Xunit;

namespace Task6_3.UnitTests
{
    public class CarTests
    {
        [Theory]
        [InlineData(4, 1200, 1500, new double[] { 55, 65, 75, 85 })]
        [InlineData(3, 1200, 1500, new double[] { 100, 100, 100 })]
        [InlineData(5, 1200, 1500, new double[] { 75, 35, 45, 65, 20 })]
        public void AddPersonsTest(int maxNumberOfPassangers, double weight, double maxWeight, double[] passangerWeights)
        {
            Car car = new Car(maxNumberOfPassangers, weight, maxWeight);

            foreach (double passangerWeight in passangerWeights)
            {
                car.AddWeight(passangerWeight);
            }

            Assert.True(car.TotalWeight <= maxWeight);
        }
    }
}
