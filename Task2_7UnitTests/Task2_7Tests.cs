using System;
using System.Collections.Generic;
using Xunit;
using static Task2_7.MathExtensions;
using Task2_7;

namespace Task2_7UnitTests
{
    public class Task2_7Tests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void SumTest(Equation equation, double[] expected, int n)
        {
            double[] actual = Sum(equation, n);
            
            Assert.Equal(Math.Round(expected[1], 3), Math.Round(actual[1], 3));
            Assert.Equal(Math.Round(expected[8], 3), Math.Round(actual[8], 3));
            Assert.Equal(Math.Round(expected[5], 3), Math.Round(actual[5], 3));
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new Equation(-1, 1, 0.25),
                new double[]
                {
                    -1.000,
                    -0.530,
                    -0.344,
                    -0.200,
                    0.000,
                    0.333,
                    0.969,
                    2.288,
                    5.000
                },
                5
            };
        }

        [Theory]
        [MemberData(nameof(SolveTestsParamsTwo))]
        public void SumTwoTest(Equation equation, double[] expected, int n)
        {
            double[] actual = SumTwo(equation, n);

            Assert.Equal(Math.Round(expected[1], 3), Math.Round(actual[1], 3));
            Assert.Equal(Math.Round(expected[8], 3), Math.Round(actual[8], 3));
            Assert.Equal(Math.Round(expected[5], 3), Math.Round(actual[5], 3));
        }

        public static IEnumerable<object[]> SolveTestsParamsTwo()
        {
            yield return new object[]
            {
                new Equation(-1, 1, 0.25),
                new double[]
                {
                    -5.000,
                    -2.288,
                    -0.969,
                    -0.333,
                    0.000,
                    0.200,
                    0.344,
                    0.530,
                    1.000
                },
                5
            };
        }
    }
}
