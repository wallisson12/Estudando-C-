using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Heranca_Polimorfismo_Ex2.Entites
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        
        //Construtor padrao
        public Product()
        {
        }

        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
