using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfPrimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, SumOfPrime.Program.SumOfPrime(1));
            Assert.AreEqual(5, SumOfPrime.Program.SumOfPrime(2));
            Assert.AreEqual(17, SumOfPrime.Program.SumOfPrime(4));
            Assert.AreEqual(0, SumOfPrime.Program.SumOfPrime(0));
            Assert.AreEqual(0, SumOfPrime.Program.SumOfPrime(-1));
        }
    }
}
