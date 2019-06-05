using TestHelpers;

using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new Class1();
            Assert.NotNull(c);
        }
    }
}