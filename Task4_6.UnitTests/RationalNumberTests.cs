using System.Collections.Generic;
using Xunit;

namespace Task4_6.UnitTests
{
    public class RationalNumberTests
    {
        [Theory]
        [MemberData(nameof(AdditionTestParams))]
        public void RationalNumberAdditionTests(int numerator, int denominator, RationalNumber x, double expected)
        {
            RationalNumber r = new RationalNumber(numerator, denominator);

            double assert = r.Add(x).Compute();

            Assert.Equal(expected, assert);
        }

        public static IEnumerable<object[]> AdditionTestParams()
        {
            yield return new object[]
            {
                0,
                -1,
                new RationalNumber(4, 2),
                2
            };

            yield return new object[]
            {
                1,
                2,
                new RationalNumber(1, 4),
                0.75
            };
        }

        [Theory]
        [MemberData(nameof(SubtractionTestParams))]
        public void RationalNumberSubtractionTests(int numerator, int denominator, RationalNumber x, double expected)
        {
            RationalNumber r = new RationalNumber(numerator, denominator);

            double assert = r.Subtract(x).Compute();

            Assert.Equal(expected, assert);
        }

        public static IEnumerable<object[]> SubtractionTestParams()
        {
            yield return new object[]
            {
                0,
                -1,
                new RationalNumber(4, 2),
                -2
            };

            yield return new object[]
            {
                1,
                2,
                new RationalNumber(1, 4),
                0.25
            };
        }

        [Theory]
        [MemberData(nameof(MultiplicationTestParams))]
        public void RationalNumberMultiplicationTests(int numerator, int denominator, RationalNumber x, double expected)
        {
            RationalNumber r = new RationalNumber(numerator, denominator);

            double assert = r.Multiply(x).Compute();

            Assert.Equal(expected, assert);
        }

        public static IEnumerable<object[]> MultiplicationTestParams()
        {
            yield return new object[]
            {
                0,
                -1,
                new RationalNumber(4, 2),
                0
            };

            yield return new object[]
            {
                1,
                2,
                new RationalNumber(1, 4),
                0.125
            };
        }

        [Theory]
        [MemberData(nameof(DivisionTestParams))]
        public void RationalNumberDivisionTests(int numerator, int denominator, RationalNumber x, double expected)
        {
            RationalNumber r = new RationalNumber(numerator, denominator);

            double assert = r.Divide(x).Compute();

            Assert.Equal(expected, assert);
        }

        public static IEnumerable<object[]> DivisionTestParams()
        {
            yield return new object[]
            {
                0,
                -1,
                new RationalNumber(4, 2),
                0
            };

            yield return new object[]
            {
                1,
                2,
                new RationalNumber(1, 4),
                2
            };
        }
    }
}
