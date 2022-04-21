using Microsoft.VisualStudio.TestTools.UnitTesting;
using mynamespace;

namespace Task_2_1_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 23;
            int expect = 1;

            Assert.AreEqual(Program.MyFunc(num), expect);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int num = 22;
            int expect = 0;

            Assert.AreEqual(Program.MyFunc(num), expect);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int num = 99;
            int expect = 0;

            Assert.AreEqual(Program.MyFunc(num), expect);
        }
    }
}