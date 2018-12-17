using Task2;
using Xunit;

namespace Task2UnitTests
{
    public class Task2Tests
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-22, 11, -11)]
        [InlineData(2, 18, 20)]
        public void TaskTwoTest(int a, int b, int expected) => 
            Assert.Equal(expected, new NumberExpression(a, b).Sum());
    }
}
