using System.Collections.Generic;
using Xunit;
using static Task3_8.ArrayExtensions;

namespace Task3_8.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void InsertArrayAtPossitionTests(int[] first, int[] second, int position, int[] expected) => 
            Assert.Equal(expected, InsertArrayAtPossition(first, second, position));

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new int[] { 0, 1, 2, 3, 4 },
                new int[] { 11, 22, 33 },
                2,
                new int[] { 0, 1, 11, 22, 33, 2, 3, 4 }
            };

            yield return new object[]
            {
                new int[] { 0, 1, 2, 3, 4 },
                new int[] { 11, 22, 33 },
                -2,
                new int[] { 11, 22, 33, 0, 1, 2, 3, 4 }
            };

            yield return new object[]
            {
                new int[] { 0, 1, 2,  3, 4 },
                new int[] { 11, 22, 33 },
                8,
                new int[] { 0, 1, 2, 3, 4, 11, 22, 33 }
            };
        }
    }
}
