using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.UnitTests
{
    public class PerishableCommodityTests
    {
        PerishableCommodity sausage;

        [SetUp]
        public void Setup()
        {
            sausage = new PerishableCommodity("6srs7", "Колбаса", 120, 150, UnitOfMeasure.Thing, 30, TimeMeasure.Day);
            sausage.Description = "докторская колбоса. 500 гр. Продукт может содержать примеси порошка рыбы";
            sausage.Amount = 120;
        }

        [Test]
        public void ConstructorPCTest()
        {
            Assert.That(sausage.MaxShelfLife, Is.EqualTo(30));
            Assert.That(sausage.ShelfLifeType, Is.EqualTo(TimeMeasure.Day));
        }

        [Test]
        public void GetInfoTest()
        {
            string expectedInfo = "6srs7. Колбаса - докторская колбоса. 500 гр. Продукт может содержать примеси порошка рыбы.";
            expectedInfo += "Оптовая цена = 120 р/шт. Розничная цена = 150 p/шт.";
            expectedInfo += "120 шт на складе.";
            expectedInfo += "\nМаксимальный срок хранения - 30 суток.";

            Assert.That(sausage.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
