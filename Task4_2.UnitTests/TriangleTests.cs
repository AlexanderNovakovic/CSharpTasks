using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Task4_2.TriangleExtensions;
using static System.Math;

namespace Task4_2.UnitTests
{
    public class TriangleTests
    {
        [Theory]
        [MemberData(nameof(SurfaceTestsParams))]
        public void TriangleSurfaceTests(Triangle[] triangles, double[] expected)
        {
            double[] actual = CalculateSurfaces(triangles);

            for (int i = 0; i < triangles.Length; i++)
            {                
                Assert.Equal(Round(expected[i], 5), Round(actual[i], 5));
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
                    new Triangle(1, 3, 5),
                    new Triangle(2, 3, 4),
                    new Triangle(5, 6, 7)
                },
                new double[]
                {
                    0.43301,
                    0.96825,
                    2.90474,
                    double.NaN,
                    6,                     
                    14.69694
                }
            };
        }
    }
}
