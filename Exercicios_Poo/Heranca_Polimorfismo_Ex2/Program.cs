using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca_Polimorfismo_Ex2.Entites; 

namespace Heranca_Polimorfismo_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int p = int.Parse(Console.ReadLine());

            for (int i =1;i<=p;i++)
            {
                Console.WriteLine("Product #" + i + " data: ");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Perguntando de qual tipo o produto eh
                Console.Write("Common, used or imported (c/u/i): ");
                char letra = char.Parse(Console.ReadLine());


                //Dependendo do produto faz uma acao diferente
                switch (letra)
                {
                    case 'i' :

                        Console.Write("Custom Free: ");
                        double custom = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                        products.Add(new ImportedProduct(name,price,custom));

                    break;


                    case 'u':

                        Console.Write("Manufacture date: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        products.Add(new UsedProduct(name, price, date));

                    break;


                    default :

                        products.Add(new Product(name, price));

                        break;

                }


            }

            //Imprime os produtos

            Console.WriteLine();

            Console.WriteLine("Price Tags: ");

            foreach (Product pr in products)
            {
                Console.WriteLine(pr.PriceTag());
            }
        }
    }
}
