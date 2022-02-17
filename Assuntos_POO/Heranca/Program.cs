using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "wallisson", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //Vai dar erro pois ela não é permitida para outras classes(Protected)
            //account.Balance = 30.0;
        }
    }
}
