using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Exercicio_Arquivo.Entites
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product(string name,double price,int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public double Total()
        {
            return Amount * Price;
        }

    }
}
