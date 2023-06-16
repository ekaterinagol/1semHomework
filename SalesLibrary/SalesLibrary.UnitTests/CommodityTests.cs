using System.Reflection;
using System;

namespace SalesLibrary.UnitTests
{
    [TestFixture]
    public class CommodityTests
    {
        static Commodity commodity;

        [SetUp]
        public void Setup()
        {
            commodity = new Commodity("01bcca", "Хлеб «Новоречко»", 28, 30, UnitOfMeasure.Package);
            commodity.Description = "хлеб белый бездрожжевой. 350 гр";
            commodity.Amount = 120;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(commodity.VendorCode, Is.EqualTo("01bcca"));
            Assert.That(commodity.Name, Is.EqualTo("Хлеб «Новоречко»"));
            Assert.That(commodity.WholesalePricePerItem, Is.EqualTo(28));
            Assert.That(commodity.RetailPricePerItem, Is.EqualTo(30));
            Assert.That(commodity.CommodityType, Is.EqualTo(UnitOfMeasure.Package));
        }

        [Test]
        public void GetInfo_Commodity_ValuesString()
        {
             string expectedInfo = "01bcca. Хлеб «Новоречко» - хлеб белый бездрожжевой. 350 гр.";
            expectedInfo += "Оптовая цена = 28 р/у. Розничная цена = 30 p/у.";
            expectedInfo += "120 у на складе.";

            Assert.That(commodity.GetInfo(), Is.EqualTo(expectedInfo));
        }

    }
}
