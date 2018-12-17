using Task4;
using Xunit;

namespace Task4UnitTests
{
    public class Task4Tests
    {
        [Theory]
        [InlineData(4.47213595499958, 5.3851648071345, 4.12310562561766, 9)]
        public void CalculateAreaTest(double a, double b, double c, double expected) => 
            Assert.Equal(expected, new Triangle(a, b, c).Area());
    }
}
