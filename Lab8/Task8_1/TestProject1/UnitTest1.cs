using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tarif discount = new TarifDiscount(new string("first"), 10, 5);
            Tarif nodiscount = new TarifNoDiscount(new string("first"), 10);

            Assert.AreEqual(discount.getPrice(), 5);
            Assert.AreEqual(nodiscount.getPrice(), 10);
        }
        [TestMethod]
        public void TestMethod2()
        {
            User user = new User();
            user.Name = new string("user");
            user.Tarif = new TarifDiscount(new string("tarif"), 10, 20);
            user.Trafic = 20;

            Assert.AreEqual(user.fullPrice(), 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Provider provider = new Provider();
            provider.tarifInput(new string("first"), 10);
            provider.tarifInput(new string("second"), 10, 5);
            provider.register(new string("first"), new string("first"), 5);
            provider.register(new string("second"), new string("second"), 5);

            Assert.AreEqual(provider.profit(), 75);
        }
    }
}