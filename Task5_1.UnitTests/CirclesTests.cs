using System.Collections.Generic;
using Xunit;

namespace Task5_1.UnitTests
{
    public class CirclesTests
    {
        [Theory]
        [MemberData(nameof(AddTestsParams))]
        public void AddTests(List<Circle> circles)
        {
            Circles circleList = new Circles();

            foreach (var circle in circles)
            {
                circleList.Add(circle);    
            }

            foreach (var circle in circles)
            {
                Assert.True(circleList.Contains(circle));                
            }
        }

        public static IEnumerable<object[]> AddTestsParams()
        {
            yield return new object[]
            {
                new List<Circle>()
                {
                    new Circle(new Point(0, 0), 2),
                    new Circle(new Point(-1, -54), 5),
                    new Circle(new Point(6, 2), 1)
                }
            };
        }

        [Theory]
        [MemberData(nameof(RemoveTestsParams))]
        public void RemoveTests(List<Circle> circles, Circle c)
        {
            Circles circleList = new Circles();

            foreach (var circle in circles)
            {
                circleList.Add(circle);
            }

            circleList.Remove(c);

            Assert.False(circleList.Contains(c));
        }

        public static IEnumerable<object[]> RemoveTestsParams()
        {
            yield return new object[]
            {
                new List<Circle>()
                {
                    new Circle(new Point(0, 0), 2),
                    new Circle(new Point(-1, -54), 5),
                    new Circle(new Point(6, 2), 1)
                },
                new Circle(new Point(0, 0), 2)
            };
        }
    }
}
