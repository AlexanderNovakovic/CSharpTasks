using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task3_1.UnitTests
{
    public class PolynomialTests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public static void PolynomialSolveTests(Polynomial polynomial, double[] coefficients, int n, double[] expected)
        {
            double[] actual = polynomial.Solve(coefficients, n);

            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(Round(expected[1], 3), Round(actual[1], 3));
            Assert.Equal(Round(expected[5], 3), Round(actual[5], 3));
            Assert.Equal(Round(expected[10], 3), Round(actual[10], 3));
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new Polynomial(-4, 4, 0.5),
                new double[] 
                {
                    4,
                    3,
                    -2,
                    1
                },
                3,
                new double[]
                {
                    -104.000,
                    -73.875,
                    -50.000,
                    -31.625,
                    -18.000,
                    -8.375,
                    -2.000,
                    1.875,
                    4.000,
                    5.125,
                    6.000,
                    7.375,
                    10.000,
                    14.625,
                    22.000,
                    32.875,
                    48.000
                }                
            };
        }
    }
}
