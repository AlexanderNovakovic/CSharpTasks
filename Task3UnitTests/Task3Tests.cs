using Task3;
using Xunit;

namespace Task3UnitTests
{
    public class Task3Tests
    {
        [Theory]
        [InlineData(2, 12.57)]
        [InlineData(4, 25.13)]
        [InlineData(34, 213.63)]
        public void CircumferenceTests(double r, double expected) => 
            Assert.Equal(expected, new Circle(r).Circumference());

        [Theory]
        [InlineData(2, 12.57)]
        [InlineData(4, 50.27)]
        [InlineData(34, 3631.68)]
        public void AreaTests(double r, double expected) => 
            Assert.Equal(expected, new Circle(r).Area());
    }
}
