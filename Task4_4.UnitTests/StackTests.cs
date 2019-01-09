using Xunit;

namespace Task4_4.UnitTests
{
    public class StackTests
    {
        [Fact]       
        public void StackTest()
        {
            Stack stack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Assert.Equal(i, stack.Peek());
            }
            
            Assert.Equal(5, stack.Count);

            for (int i = 4; i >= 0; i--)
            {
                Assert.Equal(i, stack.Peek());
                Assert.Equal(i, stack.Pop());
            }

            Assert.Equal(0, stack.Count);
        }
    }
}
