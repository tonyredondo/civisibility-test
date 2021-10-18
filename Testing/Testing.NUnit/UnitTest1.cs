using NUnit.Framework;

namespace Testing.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FactTest()
        {
            Assert.Pass("Everything is ok!");
        }

        [Theory]
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 6)]
        public void TheoryTest(int a, int b, int sum)
        {
            Assert.AreEqual(sum, a + b);
        }
    }
}