using Xunit;
using static Task3_6.ArrayExtensions;

namespace Task3_6.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 6, 7, 8 })]
        public void MergeTwoArraysAscendingTests(int[] first, int[] second, int[] expected)
        {
            int[] actual = MergeTwoArraysAscending(first, second);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
