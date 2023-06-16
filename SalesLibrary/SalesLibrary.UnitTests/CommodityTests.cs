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
            commodity = new Commodity("01bcca", "���� ����������", 28, 30, UnitOfMeasure.Package);
            commodity.Description = "���� ����� ������������. 350 ��";
            commodity.Amount = 120;
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(commodity.VendorCode, Is.EqualTo("01bcca"));
            Assert.That(commodity.Name, Is.EqualTo("���� ����������"));
            Assert.That(commodity.WholesalePricePerItem, Is.EqualTo(28));
            Assert.That(commodity.RetailPricePerItem, Is.EqualTo(30));
            Assert.That(commodity.CommodityType, Is.EqualTo(UnitOfMeasure.Package));
        }

        [Test]
        public void GetInfo_Commodity_ValuesString()
        {
            string expectedInfo = "01bcca. ���� ���������� - ���� ����� ������������. 350 ��.";
            expectedInfo += "������� ���� = 28 �/�. ��������� ���� = 30 p/�.";
            expectedInfo += "120 � �� ������.";

            Assert.That(commodity.GetInfo(), Is.EqualTo(expectedInfo));
        }

    }
}