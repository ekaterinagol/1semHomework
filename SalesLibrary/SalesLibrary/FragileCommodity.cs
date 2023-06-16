using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class FragileCommodity : Commodity
    {
        public int MaxInStack { get; set; }

        public FragileCommodity (string code, string name, double firstCost, double secondCost, 
            UnitOfMeasure commodityType, int maxInStack): base(code, name, firstCost, secondCost, commodityType)
        {
            MaxInStack = maxInStack;
        }
        /// (максимальное количество единиц товара в стопке),+добавить getinfo
        public override string GetInfo()
        {
            var commodityType = CommodityTypeDetails();
            return base.GetInfo() + $"\nМаксимальное количество товара в стопке - {MaxInStack} {commodityType}.";
        }
    }
}
