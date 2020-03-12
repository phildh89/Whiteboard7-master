using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumArrayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] input = {1,2,3,4 };
            Assert.AreEqual(10, SumArray.Program.GetSumArray(input));
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] input = { 1.20, 2.36, 3.21, 4.6 };
            Assert.AreEqual(11.37, SumArray.Program.GetSumArray(input));
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] input = { 0};
            Assert.AreEqual(0, SumArray.Program.GetSumArray(input));
        }
    }
}
