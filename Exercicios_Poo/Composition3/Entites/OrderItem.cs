using System;
using System.Collections.Generic;
using System.Text;
using Composition3.Entites;
using System.Globalization;

namespace Composition3.Entites
{
    class OrderItem
    {
        private int Quantity;
        private double Price;
        private Product Product;

        //Construtor Padrao
       public OrderItem()
       {
       }

        //Construtor Modificado
       public OrderItem(Product product,int quantity,double price)
       {
            Product = product;
            Quantity = quantity;
            Price = price;
       }

        //Metodos

        public double SubTotal()
        {
            return Price * Quantity;
        }

        //sobreescrevendo o metodo ToString
        public override string ToString()
        {
            return Product.Name + ", $: "
                   + Price.ToString("F2",CultureInfo.InvariantCulture) 
                   + " Quantity: " + Quantity
                   + " SubTotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
