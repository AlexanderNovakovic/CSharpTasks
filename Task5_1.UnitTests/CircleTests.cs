using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task5_1.UnitTests
{
    public class CircleTests
    {
        [Theory]
        [MemberData(nameof(AddTestParams))]
        public void AddTest(List<Circle> circles, int expected)
        {
            CircleList circleList = new CircleList();

            foreach (var circle in circles)
            {
                circleList.Add(circle);    
            }
            
            Assert.Equal(expected, circleList.Circles.Count);
        }

        public static IEnumerable<object[]> AddTestParams()
        {
            yield return new object[]
            {
                new List<Circle>()
                    {new Circle(new Point(0, 0), 2), new Circle(new Point(-1, -54), 5), new Circle(new Point(6, 2), 1)},
                3
            };
        }

        [Theory]
        [MemberData(nameof(DeleteTestParams))]
        public void DeleteTest(List<Circle> circles, Circle c, double expected)
        {
            CircleList circleList = new CircleList();

            foreach (var circle in circles)
            {
                circleList.Add(circle);
            }

            circleList.Remove(c);

            Assert.Equal(expected, circleList.Circles.Count);
        }

        public static IEnumerable<object[]> DeleteTestParams()
        {
            yield return new object[]
            {
                new List<Circle>()
                    {new Circle(new Point(0, 0), 2), new Circle(new Point(-1, -54), 5), new Circle(new Point(6, 2), 1)},
                new Circle(new Point(0, 0), 2),
                2
            };
        }
    }
}
