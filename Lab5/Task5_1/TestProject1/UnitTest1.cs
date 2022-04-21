using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes
{
    [TestClass]
    public class ProviderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Provider provider = new Provider();
            provider.tarifInput("First", 10);
            provider.tarifInput("Second", 5);
            provider.tarifInput("Third", 55);
            provider.tarifInput("Fourth", 0);

            provider.register("First", "Second", 1);
            provider.register("Second", "Fourth", 2);
            provider.register("Third", "Third", 1);
            provider.register("Fourth", "First", 3);

            Assert.AreEqual(provider.mainUser(), new string("Third"));
            Assert.AreEqual(provider.profit(), 90);
            Assert.AreEqual(provider.userTrafic("Second"), 2);
            Assert.AreEqual(provider.userTrafic("Third"), 1);
            Assert.AreEqual(provider.userTrafic("First"), 1);
        }
    }
}