using HRLibrary;
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
            commodity = new Commodity("01bcca", "Õëåá «Íîâîðå÷êî»", 70, 74, UnitOfMeasure.Package);
            commodity.Description = "õëåá áåëûé áåçäðîææåâîé. 350 ãð";
            commodity.Amount = 120;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(commodity.VendorCode, Is.EqualTo("01bcca"));
            Assert.That(commodity.Name, Is.EqualTo("Хлеб «Новоречко»"));
            Assert.That(commodity.WholesalePricePerItem, Is.EqualTo(70));
            Assert.That(commodity.RetailPricePerItem, Is.EqualTo(74));
            Assert.That(commodity.CommodityType, Is.EqualTo(UnitOfMeasure.Package));
        }

        [Test]
        public void GetInfo_Commodity_ValuesString()
        {
            string expectedInfo = "01bcca. Хлеб «Новоречко» - хлеб белый бездрожжевой. 350 гр."; 
            expectedInfo += "Оптовая цена = 70 р/у. Розничная цена = 74 p/у."; 
            expectedInfo += "120 у на складе."; 

            Assert.That(commodity.GetInfo(), Is.EqualTo(expectedInfo));
        }

    }
}
