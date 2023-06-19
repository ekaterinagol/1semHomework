using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.UnitTests
{
    public class DimensionalCommodityTest
    {
        DimensionalCommodity fridge;

        [SetUp]
        public void Setup()
        {
            fridge = new DimensionalCommodity("uuu12", "Холодильник «Свежо»", 12800, 14000, UnitOfMeasure.Thing);
            fridge.Description = "холодильник с морозильной камерой. Встроенная система No Frost";
            fridge.Amount = 40;
            fridge.Size = (0.7, 1, 1.7);
        }

        [Test]
        public void ConstrucorDCTest()
        {
            Assert.That(fridge.Size, Is.EqualTo((0.7, 1, 1.7)));
        }

        [Test]
        public void GetInfoTest()
        {
            string expectedInfo = "uuu12. Холодильник «Свежо» - холодильник с морозильной камерой. Встроенная система No Frost.";
            expectedInfo += "Оптовая цена = 12800 р/шт. Розничная цена = 14000 p/шт.";
            expectedInfo += "40 шт на складе.";
            expectedInfo += "\nКатегория: Габаритный товар. Размеры: длина - 0,7 м, ширина - 1 м, высота - 1,7 м.";

            Assert.That(fridge.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
