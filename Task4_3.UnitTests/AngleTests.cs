using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task4_3.UnitTests
{
    public class AngleTests
    {
        [Fact]
        public void ConvertToRadiansTests() => 
            Assert.Equal(0.785398, Round(new Angle(45, 0, 0), 6));

        [Theory]
        [InlineData(2, 0, 0)]
        [InlineData(2, 1, 2)]
        [InlineData(2, -6, -12)]
        public void MultiplyWithTests(double radians, double factor, double expected)
        {
            Angle actual = new Angle(radians) * factor;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SumWithTestsParams))]
        public void SumWithTests(Angle first, Angle second, double expected)
        {
            Angle actual = first + second;

            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> SumWithTestsParams()
        {
            yield return new object[]
            {
                new Angle(2),
                new Angle(3),
                5
            };

            yield return new object[]
            {
                new Angle(2.436),
                new Angle(3.529),
                5.965
            };
        }
    }
}
