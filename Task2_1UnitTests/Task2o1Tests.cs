using Xunit;
using static Task2._1.MathExtensions;

namespace Task2._1UnitTests
{
    public class Task2o1Tests
    {
        [Theory]
        [InlineData(new double[] { 4, 3, 1, 8, 5, 9, 2 }, 1)]
        public void MinTest(double[] numbers, double expected) =>
            Assert.Equal(expected, Min4(numbers));
    }
}
