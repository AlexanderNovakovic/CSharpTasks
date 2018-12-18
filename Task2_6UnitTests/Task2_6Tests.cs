using System;
using Xunit;
using static Task2_6.MathExtensions;

namespace Task2_6UnitTests
{
    public class Task2_6Tests
    {
        [Theory]
        [InlineData(5, 15)]
        public void SumOfNNumbersTest(int n, double expected) =>
            Assert.Equal(expected, SumOfNNumbers(n));

        [Theory]
        [InlineData(20, 2432902008176640000)]
        public void NFactorialTest(int n, long expected) =>
            Assert.Equal(expected, NFactorial(n));

        [Theory]
        [InlineData(5, 153)]
        public void SumOfNFactorialsTest(int n, long expected) =>
            Assert.Equal(expected, SumOfNFactorials(n));

        [Theory]
        [InlineData(5, 111.39838)]
        public void SumOfNFactoralsDevidedByFractionsTest(int n, double expected) =>
            Assert.Equal(expected, Math.Round(SumOfNFactoralsDevidedByFractions(n), 5));
    }
}
