using Task3;
using Xunit;

namespace Task3UnitTests
{
    public class Task3Tests
    {
        [Theory]
        [InlineData(2, 12.57)]
        [InlineData(4, 25.13)]
        [InlineData(34, 213.63)]
        public void CalculateCircumferenceTest(double r, double expected)
        {
            Circle c = new Circle();

            Assert.Equal(expected, c.CalculateCircumference(r));
        }

        [Theory]
        [InlineData(2, 12.57)]
        [InlineData(4, 50.27)]
        [InlineData(34, 3631.68)]
        public void CalculateAreaTest(double r, double expected)
        {
            Circle c = new Circle();

            Assert.Equal(expected, c.CalculateArea(r));
        }
    }
}
