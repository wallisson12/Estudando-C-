using System;
using System.Collections.Generic;
using System.Text;

namespace Composition3.Entites
{
    class Product
    {
        private string _name;
        private double Price;

        //Propriedades
        public string Name
        {
            get { return _name; }
        }

        //Construtor Padrao
        public Product()
        {
        }

        //Construtor Modificado
        public Product(string name,double price)
        {
            _name = name;
            Price = price;
        }

    }
}
