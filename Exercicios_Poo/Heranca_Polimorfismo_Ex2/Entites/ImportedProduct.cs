using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Heranca_Polimorfismo_Ex2.Entites
{
    class ImportedProduct : Product
    {
        public double CustomFree  { get; private set; }


        public ImportedProduct()
        {
        }

        public ImportedProduct(string name,double price,double customFree) : base(name,price)
        {
            CustomFree = customFree;
        }

        public double TotalPrice()
        {
            return Price + CustomFree;
        }

        public override string PriceTag()
        {
            return Name 
                   + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                   + $" (Custom Free: {CustomFree.ToString("F2", CultureInfo.InvariantCulture)}) ";
        }
    }
}
