using CSharpTasks;
using Xunit;

namespace Task1UnitTest
{
    public class Task1Test
    {
        [Fact]
        public void TaskOneTest()
        {
            SomeText st = new SomeText();

            string actual = st.ReturnHelloWorld();

            Assert.Equal("Hello World!", actual);
        }
    }
}
