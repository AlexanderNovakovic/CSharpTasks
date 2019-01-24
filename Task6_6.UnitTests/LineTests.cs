using System.Collections.Generic;
using Xunit;
using static System.Math;
using static Task6_6.LineExtensions;

namespace Task6_6.UnitTests
{
    public class LineTests
    {
        [Theory]
        [MemberData(nameof(LineTestsParams))]
        public void LinesTests(List<Line> lines, double expectedLongestLength)
        {
            Assert.Equal(expectedLongestLength, Round(Longest(lines), 5));
        }

        public static IEnumerable<object[]> LineTestsParams()
        {
            yield return new object[]
            {
                new List<Line>()
                {
                    new Distance(new Point(1, 1), new Point(2, 2)),
                    new Polyline(new Point[] {new Point(0, 0), new Point(0, 2), new Point(2, 0) }),
                    new Polygon(new Point[] {new Point(0, 0), new Point(1, 0), new Point(1, 1) })
                },
                ExpectedLongestLength(4.82843)
            };
        }

        public static double ExpectedLongestLength(double length) => length;
    }
}
