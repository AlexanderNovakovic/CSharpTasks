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
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[10], actual[10]);
            Assert.Equal(expected[3], actual[3]);
            Assert.Equal(expected[8], actual[8]);
        }
    }
}
