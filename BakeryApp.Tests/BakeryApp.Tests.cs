using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeApp.Tests
{
  [TestClass]
  public class BakeryAppTests
  {
    [TestMethod]
    public void GetPrice_ShouldReturnPriceForOneItem_string()
    {
      Assert.AreEqual("$5", BakeryApp.Bread.GetPrice(1));
    }
    [TestMethod]
    public void GetPrice_ShouldReturnPriceForItemsWithSale_string()
    {
      Assert.AreEqual("$20", BakeryApp.Bread.GetPrice(5));
    }
  }
}