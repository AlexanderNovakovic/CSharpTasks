using Xunit;
using static Task3_5.ArrayExtensions;

namespace Task3_5.UnitTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(3, new int[] { 1, 3, 3, 1})]
        [InlineData(4, new int[] { 1, 4, 6, 4, 1 })]
        public void BinomalCoefficientsTests(int n, int[] expected)
        {
            Assert.Equal(expected, DetermineBinomialCoefficientsForGivenNumber(n));
        }
    }
}
