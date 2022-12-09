using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeApp.Tests
{
    [TestClass]
    public class BakeryAppTests
    {
        [TestMethod]
        public void GetPrice_ShouldReturnPriceForItems_string() {
            Assert.AreEqual("$10", BakeryApp.Bread.GetPrice(3));
        }
    }
}