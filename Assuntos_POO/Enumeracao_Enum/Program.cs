using System;
using Enumeracao_Enum.Entites;
using Enumeracao_Enum.Entites.Enums;

namespace Enumeracao_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um objeto e colocando valores aos seus atributos
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                //Tipo especial Enum
                Status = OrderStatus.PendingPayment,
            
            };

            Console.WriteLine(order);

            //Convertendo o tipo Enum para string
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus oss;
            Enum.TryParse("Delivered", out oss);
            
            Console.WriteLine(oss);

         

        }
    }
}
