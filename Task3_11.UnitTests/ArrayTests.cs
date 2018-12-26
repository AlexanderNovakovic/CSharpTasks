using System.Collections.Generic;
using Xunit;
using static Task3_11.ArrayExtensions;

namespace Task3_11.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void MatrixTests(int[,] matrix, int[][] expected)
        {
            Assert.Equal(expected, TriangleMatrix(matrix));
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 0, 1, 2 }, { 3, 4, 5, 6 } },
                new int[][] { new int[]{ 1 }, new int[] { 5, 6 }, new int[] { 9, 0, 1 }, new int[] { 3, 4, 5, 6 } }
            };
        }
    }
}
