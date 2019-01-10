using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task5_1.UnitTests
{
    public class PointTests
    {
        [Theory]
        [MemberData(nameof(DistanceTestParams))]
        public void DistanceTests(Point first, Point second, double expectedDistance) => 
            Assert.Equal(expectedDistance, Round(first.Distance(second), 3));

        public static IEnumerable<object[]> DistanceTestParams()
        {
            yield return new object[]
            {
                new Point(0, 0),
                new Point(0, 1),
                ExpectedDistance(1)
            };

            yield return new object[]
            {
                new Point(5, 2),
                new Point(6, -3),
                ExpectedDistance(5.099)
            };

            yield return new object[]
            {
                new Point(0, 0),
                new Point(0, 0),
                ExpectedDistance(0)
            };
        }

        public static double ExpectedDistance(double value) => value;
    }
}
