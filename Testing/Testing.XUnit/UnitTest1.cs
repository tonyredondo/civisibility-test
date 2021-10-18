using Xunit;

namespace Testing.XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void FactTest()
        {
            Assert.True(true, "Everything is ok!");
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        public void TheoryTest(int a, int b, int sum)
        {
            Assert.Equal(sum, a + b);
        }
    }
}