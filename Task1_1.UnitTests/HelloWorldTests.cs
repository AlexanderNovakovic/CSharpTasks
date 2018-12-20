using Xunit;

namespace Task1_1.UnitTest
{
    public class HelloWorldTests
    {
        [Fact]
        public void OutputTest() => 
            Assert.Equal("Hello World!", new HelloWorld().Output());
    }
}
