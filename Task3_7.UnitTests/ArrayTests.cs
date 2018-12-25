using Xunit;
using static Task3_7.ArrayExtensions;

namespace Task3_7.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(new int[] { 7, 4, 6, 6, 1, 2, 2, 8 }, new int[] { 1, 2, 2, 4, 6, 6, 7, 8 })]
        public void SortTests(int[] numbers, int[] expected) => 
            Assert.Equal(expected, Sort(numbers));

        [Theory]
        [InlineData(new int[] { 7, 4, 6, 6, 1, 2, 2, 8 }, new int[] { 1, 2, 2, 4, 6, 6, 7, 8 })]
        public void InsertionSortTests(int[] numbers, int[] expected) =>
           Assert.Equal(expected, InsertionSort(numbers));
    }
}
