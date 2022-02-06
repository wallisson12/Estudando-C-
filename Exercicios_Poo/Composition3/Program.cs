using System;
using System.Globalization;
using Composition3.Entites;
using Composition3.Entites.Enums;

namespace Composition3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            //Instanciando um client
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data");

            Console.Write("Status: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            //Instanciando Order
            Order order = new Order(client, DateTime.Now,status);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count++;
                Console.WriteLine("Enter #" + count + " item data");

                Console.Write("Product name: ");
                string p_Name = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Instanciando um product
                Product product = new Product(p_Name, price);


                //Instanciando um item
                OrderItem orderItem = new OrderItem(product, quantity, price);

                order.AddItem(orderItem);
                
            }

            Console.WriteLine(order);
        }
    }
}
