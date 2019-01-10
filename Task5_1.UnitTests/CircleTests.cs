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
        public void MoveTestTwo(Circle circle, double x, double y, Circle expected) =>
            Assert.Equal(expected, circle.Move(x, y));
        
        public static IEnumerable<object[]> MoveTestTwoParams()
        {
            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                1,
                2,
                new Circle(new Point(1, 2), 2),
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                0,
                0,
                new Circle(new Point(0, 0), 2),
            };
        }

        [Theory]
        [MemberData(nameof(OverlappingTestParams))]
        public void OverlappingTest(Circle circle, Circle other, bool expected) =>
            Assert.Equal(expected, circle.IsOverlapping(other));        

        public static IEnumerable<object[]> OverlappingTestParams()
        {
            yield return new object[]
            {
                new Circle(new Point(0, 0), 1),
                new Circle(new Point(2, 2), 1),
                false
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 2),
                new Circle(new Point(0, 0), 3),
                true
            };

            yield return new object[]
            {
                new Circle(new Point(0, 0), 0.5),
                new Circle(new Point(0, 1), 0.5),
                false
            };
        }
    }
}
