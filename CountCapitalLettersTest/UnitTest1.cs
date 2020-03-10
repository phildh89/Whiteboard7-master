using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountCapitalLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, CountCapitalLetters.Program.CountCap("The Quick Brown Fox"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(16, CountCapitalLetters.Program.CountCap("THE QUICK BROWN FOX"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, CountCapitalLetters.Program.CountCap("1+94512321!#$%"));
        }
    }
}
