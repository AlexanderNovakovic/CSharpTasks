using System.Collections.Generic;
using Xunit;

namespace Task5_1.UnitTests
{
    public class CirclesTests
    {
        [Theory]
        [MemberData(nameof(AddTestParams))]
        public void AddTest(List<Circle> circles, bool expected)
        {
            Circles circleList = new Circles();

            foreach (var circle in circles)
            {
                circleList.Add(circle);    
            }

            foreach (var circle in circles)
            {
                Assert.Equal(expected, circleList.Contains(circle));                
            }
        }

        public static IEnumerable<object[]> AddTestParams()
        {
            yield return new object[]
            {
                new List<Circle>()
                    {new Circle(new Point(0, 0), 2), new Circle(new Point(-1, -54), 5), new Circle(new Point(6, 2), 1)}, 
                true
            };
        }

        [Theory]
        [MemberData(nameof(RemoveTestParams))]
        public void DeleteTest(List<Circle> circles, Circle c, bool expected)
        {
            Circles circleList = new Circles();

            foreach (var circle in circles)
            {
                circleList.Add(circle);
            }

            circleList.Remove(c);

            Assert.Equal(expected, circleList.Contains(c));
        }

        public static IEnumerable<object[]> RemoveTestParams()
        {
            yield return new object[]
            {
                new List<Circle>()
                    {new Circle(new Point(0, 0), 2), new Circle(new Point(-1, -54), 5), new Circle(new Point(6, 2), 1)},
                new Circle(new Point(0, 0), 2),
                false
            };
        }
    }
}
