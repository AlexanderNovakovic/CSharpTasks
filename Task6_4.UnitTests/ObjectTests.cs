using System.Collections.Generic;
using Xunit;
using static Task6_4.ObjectExtensions;

namespace Task6_4.UnitTests
{
    public class ObjectTests
    {
        [Theory]
        [MemberData(nameof(AboveAverageTestParams))]
        public void AboveAverageTests(List<Object> objects, List<Object> expectedAboveAverage)
        {
            List<Object> actualAboveAverage = AboveAverage(objects);

            for (int i = 0; i < actualAboveAverage.Count; i++)
            {
                Assert.Equal(actualAboveAverage[i], expectedAboveAverage[i]);
            }
        }

        public static IEnumerable<object[]> AboveAverageTestParams()
        {
            yield return new object[]
            {
                new List<Object>()
                {
                    new RectangularPrism(0.5, 1, 2, 3),
                    new Sphere(2.8, 1),
                    new Sphere(1.8, 0.75),
                    new RectangularPrism(1.5, 2, 2, 2)
                },
                new List<Object>()
                {
                    new Sphere(2.8, 1),
                    new RectangularPrism(1.5, 2, 2, 2)
                }
            };
        }
    }
}
