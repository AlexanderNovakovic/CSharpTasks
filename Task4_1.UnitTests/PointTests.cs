using System.Collections.Generic;
using Xunit;

namespace Task4_1.UnitTests
{
    public class PointTests
    {
        [Theory]
        [MemberData(nameof(DistanceTestsParams))]
        public static void DistanceTests(double x, double y, Point point, double expected)
        {
            Point p = new Point(x, y);

            double actual = p.Distance(point);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> DistanceTestsParams()
        {
            yield return new object[]
            {
                1,
                1,
                new Point(4, 5),
                5
            };

            yield return new object[]
            {
               0,
               0,
               new Point(0, 0),
               0
            };
        }
    }
}
