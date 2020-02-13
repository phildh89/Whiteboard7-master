using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetJulianTest
{
    [TestClass]
    public class GetJulianTest  
    {
        [TestMethod]
        public void TestJulian_Jan()
        {
            Assert.AreEqual(20, GetJulianDate.Program.ConvertToJulian(1, 20));
            Assert.AreEqual(30, GetJulianDate.Program.ConvertToJulian(1, 30));
        }
        [TestMethod]
        public void TestJulian_Feb()
        {
            Assert.AreEqual(51, GetJulianDate.Program.ConvertToJulian(2, 20));
            Assert.AreEqual(61, GetJulianDate.Program.ConvertToJulian(2, 30));
        }
    }
}
