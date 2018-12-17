using CSharpTasks;
using Xunit;

namespace Task1UnitTest
{
    public class Task1Test
    {
        [Fact]
        public void TaskOneTest() => 
            Assert.Equal("Hello World!", new SomeText().HelloWorld());
    }
}
