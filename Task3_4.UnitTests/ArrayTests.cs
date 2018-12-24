using Xunit;
using static Task3_4.MathExtensions;

namespace Task3_4.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, new double[] { 5, 4, 3, 2, 1 })]
        [InlineData(new double[] { 1, 2, 3, 4, 5, 6 }, new double[] { 6, 5, 4, 3, 2, 1 })]
        public void ReverseTests(double[] numbers, double[] expected) =>
            Assert.Equal(expected, Reverse(numbers));
    }
}
