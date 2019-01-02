using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Task4_5.SetExtensions;

namespace Task4_5.UnitTests
{
    public class SetTests
    {
        [Theory]
        [MemberData(nameof(UnionTestParams))]
        public void SetUnionTests(Set s1, Set s2, double[] expected)
        {
            Set s3 = Union(s1, s2);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], s3.Arr[i]);
            }
        }

        public static IEnumerable<object[]> UnionTestParams()
        {
            yield return new object[]
            {
                new Set(new double[] { 1, 2, 3, 4 }),
                new Set(new double[] { 3, 4, 5, 6, 7 }),
                new double[] { 1, 2, 3, 4, 5, 6, 7 }
            };

            yield return new object[]
            {
                new Set(new double[] { 1, 2, 3, 4 }),
                new Set(new double[] { 1, 2, 3, 4 }),
                new double[] { 1, 2, 3 , 4 }
            };

            yield return new object[]
            {
                new Set(new double[] { 9, 3, 5, 1, 7, 3 }),
                new Set(new double[] { 6, 2, 8, 8 }),
                new double[] { 1, 2, 3, 5, 6, 7, 8, 9 }
            };
        }

        [Theory]
        [MemberData(nameof(ComplementTestParams))]
        public void SetComplementTests(Set s1, Set s2, double[] expected)
        {
            Set s3 = Complement(s1, s2);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], s3.Arr[i]);
            }
        }

        public static IEnumerable<object[]> ComplementTestParams()
        {
            yield return new object[]
            {
                new Set(new double[] { 1, 2, 3, 4 }),
                new Set(new double[] { 3, 4, 5, 6, 7 }),
                new double[] { 1, 2 }
            };

            yield return new object[]
            {
                new Set(new double[] { 1, 2, 3, 4, 3 }),
                new Set(new double[] { 3, 5, 6, 7, 8 }),
                new double[] {  }
            };

            yield return new object[]
            {
                new Set(new double[] { 9, 3, 5, 1, 7, 3 }),
                new Set(new double[] { 6, 2, 8, 8 }),
                new double[] { 1, 3, 5, 7, 9 }
            };
        }

        [Theory]
        [MemberData(nameof(IntersectionTestParams))]
        public void SetIntersectionTests(Set s1, Set s2, double[] expected)
        {
            Set s3 = Intersection(s1, s2);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], s3.Arr[i]);
            }
        }

        public static IEnumerable<object[]> IntersectionTestParams()
        {
            yield return new object[]
            {
                new Set(new double[] { 1, 2, 3, 4 }),
                new Set(new double[] { 3, 4, 5, 6, 7 }),
                new double[] { 3, 4 }
            };

            yield return new object[]
            {
                new Set(new double[] { 1, 2, 3, 4, 3 }),
                new Set(new double[] { 3, 3, 5, 6, 7, 8 }),
                new double[] { 3 }
            };

            yield return new object[]
            {
                new Set(new double[] { 9, 3, 5, 1, 7, 3 }),
                new Set(new double[] { 6, 2, 8, 8 }),
                new double[] {  }
            };
        }    
    }
}
