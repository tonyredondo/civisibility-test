using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FactTest()
        {
            Assert.IsTrue(true, "Everything is ok!");
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        public void TheoryTest(int a, int b, int sum)
        {
            Assert.AreEqual(sum, a + b);
        }        
        
    }
}