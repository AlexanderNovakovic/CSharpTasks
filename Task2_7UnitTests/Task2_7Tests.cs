using System.Collections.Generic;
using Xunit;
using Task2_7;
using static System.Math;

namespace Task2_7UnitTests
{
    public class Task2_7Tests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void SumTest(Equation equation, double[] expected, int n)
        {
            double[] actual = equation.Sum1(n);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(Round(expected[i], 3), Round(actual[i], 3));
            }            
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
            double[] actual = equation.Sum2(n);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(Round(expected[i], 3), Round(actual[i], 3));
            }
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
