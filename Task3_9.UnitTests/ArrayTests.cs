using System.Collections.Generic;
using Xunit;
using static Task3_9.ArrayExtensions;

namespace Task3_9.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [MemberData(nameof(SolveTestsParams))]
        public void MatrixTests(int[,] matrix, int[,] expected)
        {
            Assert.Equal(expected, SwitchMinWithMax(matrix));
        }

        public static IEnumerable<object[]> SolveTestsParams()
        {
            yield return new object[]
            {
                new int[,] { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } },
                new int[,] { { 6, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 1 } }
            };

            yield return new object[]
            {
                new int[,] { { 2, 2, 3, 4 }, { 1, 3, 4, 5 }, { 3, 4, 5, 6 } },
                new int[,] { { 2, 2, 3, 4 }, { 6, 3, 4, 5 }, { 3, 4, 5, 1 } }
            };
        }
    }
}
