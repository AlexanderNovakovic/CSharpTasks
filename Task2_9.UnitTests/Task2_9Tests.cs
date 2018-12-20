using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Task2_9.MathExtensions;

namespace Task2_9.UnitTests
{
    public class Task2_9Tests
    {
        [Fact]
        public void SumAscendingTests() =>        
            Assert.Equal(1.46361, Round(SumAscending(5), 5));

        [Theory]
        [InlineData(100, 1.634984)]
        [InlineData(200, 1.639947)]
        [InlineData(500, 1.642936)]
        [InlineData(1000, 1.643935)]
        [InlineData(2000, 1.644434)]
        [InlineData(5000, 1.644734)]
        [InlineData(10000, 1.644834)]
        public void SumAscendingTestsTwo(int n, double expected) =>
            Assert.Equal(expected, Round(SumAscending(n), 6));

        [Fact]
        public void SumDescendingTests() =>
            Assert.Equal(1.46361, Round(SumDescending(5), 5));

        [Theory]
        [InlineData(100, 1.634984)]
        [InlineData(200, 1.639947)]
        [InlineData(500, 1.642936)]
        [InlineData(1000, 1.643935)]
        [InlineData(2000, 1.644434)]
        [InlineData(5000, 1.644734)]
        [InlineData(10000, 1.644834)]
        public void SumDescendingTestsTwo(int n, double expected) =>
            Assert.Equal(expected, Round(SumDescending(n), 6));
    }
}
