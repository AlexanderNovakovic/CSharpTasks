using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static System.Math;

namespace Task5_1.UnitTests
{
    public class PointTests
    {
        [Theory]
        [MemberData(nameof(DistanceTestParams))]
        public void DistanceTests(Point first, Point second, double expected) => 
            Assert.Equal(expected, Round(first.Distance(second), 3));

        public static IEnumerable<object[]> DistanceTestParams()
        {
            yield return new object[]
            {
                new Point(0, 0),
                new Point(0, 1),
                Expected(1)
            };

            yield return new object[]
            {
                new Point(5, 2),
                new Point(6, -3),
                Expected(5.099)
            };

            yield return new object[]
            {
                new Point(0, 0),
                new Point(0, 0),
                Expected(0)
            };
        }

        public static double Expected(double value) => value;
    }
}
