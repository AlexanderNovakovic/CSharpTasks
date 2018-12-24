using Xunit;
using static Task3_3.DoubleExtensions;

namespace Task3_3.UnitTests
{
    public class ArrayUnitTests
    {
        [Theory]
        [InlineData(new double[] { 8, 3, 6, 2, 3 }, 2)]
        public void MinimumTests(double[] numbers, double expected) =>
            Assert.Equal(expected, Minimum(numbers));
    }
}
