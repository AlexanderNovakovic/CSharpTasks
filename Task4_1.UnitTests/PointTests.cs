using System.Collections.Generic;
using Xunit;

namespace Task4_1.UnitTests
{
    public class PointTests
    {
        [Theory]
        [MemberData(nameof(DistanceTestsParams))]
        public static void DistanceTests(Point p1, Point p2, double expectedDistance)
        {
            double actual = p1.Distance(p2);

            Assert.Equal(expectedDistance, actual);
        }

        public static IEnumerable<object[]> DistanceTestsParams()
        {
            yield return new object[]
            {
                new Point(1, 1), 
                new Point(4, 5),
                ExpectedDistance(5)
            };

            yield return new object[]
            {
               new Point(0, 0),
               new Point(0, 0),
               ExpectedDistance(0)
            };
        }

        private static int ExpectedDistance(int distance) =>
            distance;
    }
}
