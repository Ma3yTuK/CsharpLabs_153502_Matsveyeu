using Microsoft.VisualStudio.TestTools.UnitTesting;
using mynamespace;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 10;
            double y = 10;
            int expected = 1;

            Assert.AreEqual(Program.MyFunc(x, y), expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 19.99;
            double y = 19.99;
            int expected = 1;

            Assert.AreEqual(Program.MyFunc(x, y), expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double x = 40;
            double y = 40;
            int expected = 0;

            Assert.AreEqual(Program.MyFunc(x, y), expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double x = -80;
            double y = 40;
            int expected = -1;

            Assert.AreEqual(Program.MyFunc(x, y), expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double x = -40;
            double y = 40;
            int expected = 0;

            Assert.AreEqual(Program.MyFunc(x, y), expected);
        }
    }
}