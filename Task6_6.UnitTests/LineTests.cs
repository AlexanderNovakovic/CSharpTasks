using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task6_6.UnitTests
{
    public class LineTests
    {
        [Theory]
        [MemberData(nameof(LineTestsParams))]
        public void LinesTests(List<ILine> lines, double expectedLongestLength)
        {
            var actualLongestLength = Round(lines.Longest().Length, 5);

            Assert.Equal(expectedLongestLength, actualLongestLength);
        }

        public static IEnumerable<object[]> LineTestsParams()
        {
            yield return new object[]
            {
                new List<ILine>
                {
                    new Distance(new Point(1, 1), new Point(2, 2)),
                    new Polyline(new[] {new Point(0, 0), new Point(0, 2), new Point(2, 0) }),
                    new Polygon(new[] {new Point(0, 0), new Point(1, 0), new Point(1, 1) })
                },
                ExpectedLongestLength(4.82843)
            };
        }

        public static double ExpectedLongestLength(double length) => length;
    }
}
