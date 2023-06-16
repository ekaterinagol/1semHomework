using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary
{
    public class Commodity
    {
        public readonly string VendorCode; //string - так как артикул может содежать и числа, и буквы
        public string Name { get; set; }
        public double WholesalePricePerItem { get; set; }
        public double RetailPricePerItem { get; set; }
        public UnitOfMeasure CommodityType;

        public string Description;
        public double Amount;

        public Commodity(string code, string name, double firstCost, double secondCost, UnitOfMeasure commodityType)
        {
            VendorCode = code;
            Name = name;
            WholesalePricePerItem = firstCost;
            RetailPricePerItem = secondCost;
            CommodityType = commodityType;
        }

        public virtual string GetInfo()
        {
            var commodityType = CommodityTypeDetails();
            return $"{VendorCode}. {Name} - {Description}." +
                $"Оптовая цена = {WholesalePricePerItem} р/{commodityType}. Розничная цена = {RetailPricePerItem} p/{commodityType}." +
                $"{Amount} {commodityType} на складе.";
        }

        public string CommodityTypeDetails()
        {
            var commodityType = "";
            if (CommodityType == UnitOfMeasure.Thing)
                commodityType = "шт";
            else if (CommodityType == UnitOfMeasure.Package)
                commodityType = "у";
            else if (CommodityType == UnitOfMeasure.Kilogramm)
                commodityType = "кг";
            else if (CommodityType == UnitOfMeasure.Ton)
                commodityType = "т";
            return commodityType;
        }
    }
}