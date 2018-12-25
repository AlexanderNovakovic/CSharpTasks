using Xunit;
using static Task3_2.DoubleExtensions;

namespace Task3_2.UnitTests
{
    public class Task3_2Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 4.5)]
        [InlineData(new int[] { 3, 6, 9, 12, 15 }, 9)]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 0)]
        public void Task3Tests(int[] numbers, double expected) =>
            Assert.Equal(expected, Average(numbers));
    }
}
