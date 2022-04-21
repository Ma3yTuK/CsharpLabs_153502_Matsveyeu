using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNamespace;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "01.01.0000";
            int expect = 6;

            Assert.AreEqual(expect, DateService.GetDay(str));
        }
        [TestMethod]
        public void TestMethod2()
        {
            string str = "24.03.2022";
            int expect = 4;

            Assert.AreEqual(expect, DateService.GetDay(str));
        }
        [TestMethod]
        public void TestMethod3()
        {
            string str = "29.02.2024";
            int expect = 4;

            Assert.AreEqual(expect, DateService.GetDay(str));
        }
        [TestMethod]
        public void TestMethod4()
        {
            string str = "29.02.2022";
            int expect = -1;

            Assert.AreEqual(expect, DateService.GetDay(str));
        }
        [TestMethod]
        public void TestMethod5()
        {
            string str = "28.02.2022";
            int expect = 24;

            Assert.AreEqual(expect, DateService.GetSpan(str));
        }
        [TestMethod]
        public void TestMethod6()
        {
            string str = "29.02.2024";
            int expect = 707;

            Assert.AreEqual(expect, DateService.GetSpan(str));
        }
        [TestMethod]
        public void TestMethod7()
        {
            string str = "29.02.2023";
            int expect = -1;

            Assert.AreEqual(expect, DateService.GetSpan(str));
        }
        [TestMethod]
        public void TestMethod8()
        {
            int x = 10;
            int expect = 1;

            Assert.AreEqual(expect, Numbers.MyFunc(x));
        }
        [TestMethod]
        public void TestMethod9()
        {
            int x = 39;
            int expect = 93;

            Assert.AreEqual(expect, Numbers.MyFunc(x));
        }
        [TestMethod]
        public void TestMethod10()
        {
            int x = 1;
            int expect = 1;

            Assert.AreEqual(expect, Numbers.MyFunc(x));
        }
        [TestMethod]
        public void TestMethod11()
        {
            int x = 101;
            int expect = 101;

            Assert.AreEqual(expect, Numbers.MyFunc(x));
        }
        [TestMethod]
        public void TestMethod12()
        {
            double z = 10;
            double b = 2;
            double expect = 3.57;

            Assert.AreEqual(expect, Calc.MyFunc(z, b), 1e-2);
        }
        [TestMethod]
        public void TestMethod13()
        {
            double z = -0.1;
            double b = 2;
            double expect = 1.29;

            Assert.AreEqual(expect, Calc.MyFunc(z, b), 1e-2);
        }
    }
}