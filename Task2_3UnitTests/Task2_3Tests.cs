using Xunit;
using static Task2_3.MathExtensions;

namespace Task2_3UnitTests
{
    public class Task2_3Tests
    {
        [Theory]
        [InlineData(1, 4, 2, 5, 3, 6, new double[] { -1, 2 })]
        public void SolveSystemOfTwoEquationsTest(double a1, double a2, double b1, double b2, double c1, double c2, double[] expected) =>
            Assert.Equal(expected, Solve(DeterminatX(b1, b2, c1, c2), DeterminantY(a1, a2, c1, c2), Determinant(a1, a2, b1, b2)));
    }
}
