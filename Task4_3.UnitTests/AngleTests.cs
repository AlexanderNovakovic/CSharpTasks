using System.Collections.Generic;
using Xunit;
using static Task4_3.Angle;
using static System.Math;

namespace Task4_3.UnitTests
{
    public class AngleTests
    {
        [Fact]
        public void ConvertToRadiansTests() => 
            Assert.Equal(0.785398, Round(ConvertToRadians(45, 0, 0), 6));

        [Theory]
        [InlineData(2, 0, 0)]
        [InlineData(2, 1, 2)]
        [InlineData(2, -6, -12)]
        public void MultiplyWithTests(double radians, double number, double expected)
        {
            Angle angle = new Angle(radians);

            Assert.Equal(expected, angle.MultiplyWith(number));
        }

        [Theory]
        [MemberData(nameof(SumWithTestsParams))]
        public void SumWithTests(double radians, Angle secondAngle, double expected)
        {
            Angle angle = new Angle(radians);

            Assert.Equal(expected, angle.SumWith(secondAngle));
        }


        public static IEnumerable<object[]> SumWithTestsParams()
        {
            yield return new object[]
            {
                2,
                new Angle(3),
                5
            };

            yield return new object[]
            {
                2.436,
                new Angle(3.529),
                5.965
            };
        }
    }
}
