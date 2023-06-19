using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class PerishableCommodity : Commodity
    {
        public int MaxShelfLife;
        public TimeMeasure ShelfLifeType;

        public PerishableCommodity(string code, string name, double firstCost, double secondCost,
            UnitOfMeasure commodityType, int maxShelfLife, TimeMeasure shelfLifeType) : base(code, name, firstCost, secondCost, commodityType)
        {
            MaxShelfLife = maxShelfLife;
            ShelfLifeType = shelfLifeType;
        }

        public override string GetInfo()
        {
            var shelfLifeType = ShelfLifeDetails();

            return base.GetInfo() + $"\nМаксимальный срок хранения - {MaxShelfLife} {shelfLifeType}.";
        }

        public string ShelfLifeDetails()
        {
            var shelfLifeType = "";
            if (ShelfLifeType == TimeMeasure.Hour)
            {
                if (MaxShelfLife == 1)
                    shelfLifeType = "час";
                else if (MaxShelfLife > 1 && MaxShelfLife < 5)
                    shelfLifeType = "часа";
                else if (MaxShelfLife > 4)
                    shelfLifeType = "часов";
            }

            else if (ShelfLifeType == TimeMeasure.Day)
            {
                if (MaxShelfLife == 1)
                    shelfLifeType = "сутки";
                else if (MaxShelfLife > 1)
                    shelfLifeType = "суток";
            }

            else if (ShelfLifeType == TimeMeasure.Year)
            {
                if (MaxShelfLife == 1)
                    shelfLifeType = "год";
                else if (MaxShelfLife > 1 && MaxShelfLife < 5)
                    shelfLifeType = "года";
                else if (MaxShelfLife > 4)
                    shelfLifeType = "лет";
            }
            return shelfLifeType;
        }
    }

}
