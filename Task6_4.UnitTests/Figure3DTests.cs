using System.Collections.Generic;
using Xunit;

namespace Task6_4.UnitTests
{
    public class Figure3DTests
    {
        [Theory]
        [MemberData(nameof(AboveAverageTestParams))]
        public void AboveAverageTests(List<Figure3D> shapes, List<Figure3D> expectedAboveAverage)
        {
            List<Figure3D> actualAboveAverage = shapes.WithAboveAverageMass();

            for (int i = 0; i < actualAboveAverage.Count; i++)
            {
                Assert.Equal(actualAboveAverage[i], expectedAboveAverage[i]);
            }
        }

        public static IEnumerable<object[]> AboveAverageTestParams()
        {
            yield return new object[]
            {
                new List<Figure3D>
                {
                    new Figure3D(0.5, new RectangularPrism(1, 2, 3)),
                    new Figure3D(2.8, new Sphere(1)),
                    new Figure3D(1.8, new Sphere(0.75)),
                    new Figure3D(1.5, new RectangularPrism(2, 2, 2))
                },
                new List<Figure3D>()
                {
                    new Figure3D(2.8, new Sphere(1)),
                    new Figure3D(1.5, new RectangularPrism(2, 2, 2))
                }
            };
        }
    }
}
