using System.Collections.Generic;
using Xunit;

namespace Task6_5.UnitTests
{
    public class PointTests
    {
        [Theory]
        [MemberData(nameof(MoveToTestParams))]
        public void MoveToTests(Point point, double dx, double dy, Point expectedPoint) =>
            Assert.Equal(expectedPoint, point.Move(dx, dy));

        public static IEnumerable<object[]> MoveToTestParams()
        {
            yield return new object[]
            {
                new Point(0, 0),
                Dx(1),
                Dy(2),
                new Point(1, 2)
            };

            yield return new object[]
            {
                new Point(0, 0),
                Dx(3),
                Dy(-4),
                new Point(3, -4)
            };
        }

        public static double Dx(double dx) => dx;
        public static double Dy(double dy) => dy;
    }
}
