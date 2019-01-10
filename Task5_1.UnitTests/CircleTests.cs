using System.Collections.Generic;
using Xunit;

namespace Task5_1.UnitTests
{
    public class CircleTests
    {
        [Theory]
        [MemberData(nameof(MoveTestParams))]
        public void MoveTest(Circle circle, Point point, Circle expected) =>        
            Assert.Equal(expected, circle.Move(point));
        
        public static IEnumerable<object[]> MoveTestParams()
        {
            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                new Point(1, 2),
                new Circle(new Point(1, 2), 2),
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                new Point(0, 0),
                new Circle(new Point(0, 0), 2),
            };
        }

        [Theory]
        [MemberData(nameof(MoveTestTwoParams))]
        public void MoveTestTwo(Circle circle, double dx, double dy, Circle expected) =>
            Assert.Equal(expected, circle.Move(dx, dy));
        
        public static IEnumerable<object[]> MoveTestTwoParams()
        {
            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                Dx(1),
                Dy(2),
                new Circle(new Point(1, 2), 2),
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                Dx(0),
                Dy(0),
                new Circle(new Point(0, 0), 2),
            };
        }

        public static int Dx(int dx) => dx;
        public static int Dy(int dy) => dy;

        [Theory]
        [MemberData(nameof(OverlappingTestParams))]
        public void OverlappingTest(Circle circle, Circle other, bool expectedIsOverlapping) =>
            Assert.Equal(expectedIsOverlapping, circle.IsOverlapping(other));        

        public static IEnumerable<object[]> OverlappingTestParams()
        {
            yield return new object[]
            {
                new Circle(new Point(0, 0), 1),
                new Circle(new Point(2, 2), 1),
                AreOverlapping(false)
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                new Circle(new Point(0, 0), 3),
                AreOverlapping(true)
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 0.5),
                new Circle(new Point(0, 1), 0.5),
                AreOverlapping(false)
            };
        }

        public static bool AreOverlapping(bool areOverlapping) => areOverlapping;
    }
}
