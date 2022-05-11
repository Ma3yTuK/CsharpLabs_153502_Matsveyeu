using Task7_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoubleConversion()
        {
            Circle circle1 = new Circle(1, 1, 1);
            Circle circle2 = new Circle(1, 1, -1);

            Assert.AreEqual((double)circle1, 1, 1e-9);
            Assert.AreEqual((double)circle2, 0, 1e-9);
        }
        [TestMethod]
        public void GettersSetters()
        {
            Circle circle = new Circle(1, 1, 1);
            circle.Radius = -1;
            circle.X = 1;
            circle.Y = -1;

            Assert.AreEqual(circle.Radius, 0, 1e-9);
            Assert.AreEqual(circle.X, 1, 1e-9);
            Assert.AreEqual(circle.Y, -1, 1e-9);
        }
        [TestMethod]
        public void FromDoubleConversion()
        {
            double a = 0;
            double b = -10;
            double c = 10;

            Assert.AreEqual(((Circle)a).Radius, 0, 1e-9);
            Assert.AreEqual(((Circle)b).Radius, 0, 1e-9);
            Assert.AreEqual(((Circle)c).Radius, 10, 1e-9);
        }
        [TestMethod]
        public void Square()
        {
            Circle circle = new Circle(10, -100, -10);

            Assert.AreEqual(circle.Square(), 0, 1e-9);
        }
        [TestMethod]
        public void Perimetr()
        {
            Circle circle = new Circle(10, -100, -10);

            Assert.AreEqual(circle.Perimetr(), 0, 1e-9);
        }
        [TestMethod]
        public void Indexation()
        {
            Circle circle = new Circle(10, -100, -10);

            Assert.AreEqual(circle[0], circle.X, 1e-9);
            Assert.AreEqual(circle[1], circle.Y, 1e-9);
            Assert.AreEqual(circle[2], circle.Radius, 1e-9);
            Assert.AreEqual(circle[4], 0, 1e-9);
        }
        [TestMethod]
        public void Decrement()
        {
            Circle circle = new Circle(10, -100, 2);

            Assert.AreEqual((--circle).Radius, 1, 1e-9);
            Assert.AreEqual((--circle).Radius, 0, 1e-9);
            Assert.AreEqual((--circle).Radius, 0, 1e-9);
        }
        [TestMethod]
        public void Substraction()
        {
            Circle circle1 = new Circle(10, -100, 2);
            Circle circle2 = new Circle(10, -100, 1);

            Assert.AreEqual((circle1-circle2).Radius, 1, 1e-9);
            Assert.AreEqual((circle1 - circle2 - circle2).Radius, 0, 1e-9);
            Assert.AreEqual((circle1 - circle2-circle2-circle2).Radius, 0, 1e-9);
        }
        [TestMethod]
        public void Devision()
        {
            Circle circle1 = new Circle(10, -100, 2);
            Circle circle2 = new Circle(10, -100, 2);
            Circle circle3 = new Circle(10, -100, 0);

            Assert.AreEqual((circle1/circle2).Radius, 1, 1e-9);
            Assert.AreEqual((circle1 / circle3).Radius, 0, 1e-9);
        }
        [TestMethod]
        public void Comparisons()
        {
            Circle circle1 = new Circle(10, -100, 2);
            Circle circle2 = new Circle(10, -100, 2);
            Circle circle3 = new Circle(10, -100, 1);
            Circle circle4 = new Circle(10, -100, 3);

            Assert.AreEqual(circle1==circle2, true);
            Assert.AreEqual(circle1 != circle2, false);
            Assert.AreEqual(circle1 < circle4, true);
            Assert.AreEqual(circle4 > circle3, true);
            if (circle4)
                return;
            Assert.Fail();
        }
    }
}