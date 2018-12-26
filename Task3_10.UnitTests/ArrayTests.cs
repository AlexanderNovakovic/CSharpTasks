using System.Collections.Generic;
using Xunit;
using static Task3_10.ArrayExtensions;

namespace Task3_10.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void MatrixTests(int[,] matrix, int[,] expected)
        {
            Assert.Equal(expected, Transpose(matrix));
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } },
                new int[,] { { 1, 5, 9 }, { 2, 6, 10 }, { 3, 7, 11 }, { 4, 8, 12 } }
            };
        }
    }
}
