using Xunit;
using static Task2_2.MathExtensions;

namespace Task2_2UnitTests
{
    public class Task2_2Tests
    {
        [Theory]
        [InlineData(new double[] { 7, 3, 66, 12, 5 }, new double[] { 3, 5, 7, 12, 66 })]
        public static void SortAscendingTest(double[] numbers, double[] expected) =>
            Assert.Equal(expected, SortAscending(numbers));
    }
}
