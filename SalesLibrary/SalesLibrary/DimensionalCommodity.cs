using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class DimensionalCommodity : Commodity
    {
        public (double Length, double Width, double Height) Size { get; set; }

        public DimensionalCommodity(string code, string name, double firstCost, double secondCost,
            UnitOfMeasure commodityType ) : base(code, name, firstCost, secondCost, commodityType) {}
        // будем измерять все в метрах
        
        public override string GetInfo() => base.GetInfo() + $"\nКатегория: Габаритный товар. Размеры: длина - {Size.Length} м, " +
                $"ширина - {Size.Width} м, высота - {Size.Height} м.";
    }
}
