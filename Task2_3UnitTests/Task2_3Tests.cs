using System.Collections.Generic;
using Task2_3;
using Xunit;
using static Task2_3.MathExtensions;

namespace Task2_3UnitTests
{
    public class Task2_3Tests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void SolveSystemOfTwoEquationsTest(Equation first, Equation second, EquationSoultion expected)
        {
            EquationSoultion actual = Solve(first, second);

            Assert.Equal(expected.X, actual.X);
            Assert.Equal(expected.Y, actual.Y);
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new Equation(1, 2, 3),
                new Equation(4, 5, 6),
                new EquationSoultion(-1, 2)
            };
        }
    }
}
