using System.Collections.Generic;
using Xunit;
using static System.Math;

namespace Task4_2.UnitTests
{
    public class TriangleTests
    {
        [Theory]
        [MemberData(nameof(SurfaceTestsParams))]
        public void TriangleSurfaceTests(Triangle[] triangles, double[] expected)
        {
            double[] actual = triangles.SortedAreas();
            for (int i = 0; i < triangles.Length; i++)
            {
                actual[i] = Round(actual[i], 5);
            }

            for (int i = 0; i < triangles.Length; i++)
            {                
                Assert.Equal(expected[i], actual[i]);
            }
        }

        public static IEnumerable<object[]> SurfaceTestsParams()
        {
            yield return new object[]
            {
                new Triangle[] {
                    new Triangle(1, 1, 1),
                    new Triangle(3, 4, 5),
                    new Triangle(1, 2, 2),
                    new Triangle(2, 3, 4),
                    new Triangle(5, 6, 7)
                },
                new double[]
                {
                    0.43301,
                    0.96825,
                    2.90474,
                    6,                     
                    14.69694
                }
            };
        }
    }
}
