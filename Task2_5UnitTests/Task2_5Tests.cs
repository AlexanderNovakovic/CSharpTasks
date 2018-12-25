using System.Collections.Generic;
using Xunit;
using Task2_5;
using static System.Math;

namespace Task2_5UnitTests
{
    public class Task2_5Tests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void SolveEquationTest(Equation equation, double[] expected)
        {
            double[] actual = equation.Solve();
           
            Assert.Equal(expected.Length, actual.Length);
            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(Round(expected[i], 5), Round(actual[i], 5));
            }
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new Equation(-2, 2, 0.2),
                new double[]
                {
                    1.2,
                    1.14150943396226,
                    1.0561797752809,
                    0.932432432432433,
                    0.754098360655738,
                    0.5,
                    0.146341463414635,
                    -0.323529411764705,
                    -0.89655172413793,
                    -1.5,
                    -2,
                    -2.26923076923077,
                    -2.27586206896552,
                    -2.08823529411765,
                    -1.80487804878049,
                    -1.5,
                    -1.21311475409836,
                    -0.95945945945946,
                    -0.741573033707866,
                    -0.556603773584906,
                    -0.4
                }
            };
        }
    }
}
