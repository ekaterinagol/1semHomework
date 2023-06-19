using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.UnitTests
{
    public class FragileCommodityTests
    {
        FragileCommodity wineglass;

        [SetUp]
        public void Setup()
        {
            wineglass = new FragileCommodity("rf005", "Бокалы «Красиводома»", 500, 600, UnitOfMeasure.Package, 5);
            wineglass.Description = "бокалы по 6 штук в уп. Производитель: «Стеклодома»";
            wineglass.Amount = 50;
        }

        [Test]
        public void ConstructorFCTest()
        {
            Assert.That(wineglass.MaxInStack, Is.EqualTo(5));
        }

        [Test]
        public void GetInfoTest()
        {
            string expectedInfo = "rf005. Бокалы «Красиводома» - бокалы по 6 штук в уп. Производитель: «Стеклодома».";
            expectedInfo += "Оптовая цена = 500 р/у. Розничная цена = 600 p/у.";
            expectedInfo += "50 у на складе.";
            expectedInfo += "\nМаксимальное количество товара в стопке - 5 у.";

            Assert.That(wineglass.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
