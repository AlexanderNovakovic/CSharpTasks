using Xunit;
using static Task2_4.MathExtensions;

namespace Task2_4UnitTests
{
    public class Task2_4Tests
    {
        [Theory]
        [InlineData(1, 1, 1, new double[] { -0.5, 0.8660254037844386, -0.5, -0.8660254037844386 })]
        public void SolveQuadraticEquationTest(double a, double b, double c, double[] expected) =>
            Assert.Equal(expected, SolveQuadraticEquation(a, b, c));
    }
}
