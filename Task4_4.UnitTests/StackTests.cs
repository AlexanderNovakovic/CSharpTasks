using Xunit;

namespace Task4_4.UnitTests
{
    public class StackTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3, 4}, 0)]        
        public void StackPeekTests(int[] numbers, int expected)
        {
            Stack s = InitializeStack(numbers);

            int actual = s.Peek();
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3, 4 }, 5)]
        public void StackSizeTests(int[] numbers, int expected)
        {
            Stack s = InitializeStack(numbers);

            int actual = s.NumberOfElements();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 2, 3, 4 }, 1)]
        public void StackPopTests(int[] numbers, int expected)
        {
            Stack s = InitializeStack(numbers);

            s.Pop();

            int actual = s.Peek();

            Assert.Equal(expected, actual);
        }

        public static Stack InitializeStack(int[] numbers)
        {
            Stack s = new Stack();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                s.Push(i);
            }

            return s;
        }
    }
}
