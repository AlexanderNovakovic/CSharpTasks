using Xunit;
using static System.Math;
using static Task2_8.MathExtensions;

namespace Task2_8UnitTests
{
    public class Task2_8Tests
    {
        [Theory]
        [InlineData(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4.5)]
        [InlineData(new double[] { 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 }, 4.5)]
        [InlineData(new double[] { 0, 0, 0, 0, 0, 9, 9, 9, 9, 9 }, 4.5)]
        public void ArithmeticMeanTest(double[] numbers, double expected) =>
            Assert.Equal(expected, ArithmeticMean(numbers, numbers.Length));

        [Theory]
        [InlineData(new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2.9)]
        [InlineData(new double[] { 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 }, 0.5)]
        [InlineData(new double[] { 0, 0, 0, 0, 0, 9, 9, 9, 9, 9 }, 4.5)]
        public void StandardDeviationTest(double[] numbers, double expected) =>
            Assert.Equal(expected, Round(StandardDeviation(numbers, numbers.Length), 1));
    }
}
