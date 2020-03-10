using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountCharTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(16, CountChar.Program.CountChar("The Quick Brown Fox"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(16, CountChar.Program.CountChar("123342453466*$9387$The Quick Brown Fox"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(16, CountChar.Program.CountChar("The   Quick    Brown                Fox"));
        }
    }
}
