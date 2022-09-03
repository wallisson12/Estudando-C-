using System;
using Relembrando.Entites;

namespace Relembrando
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto do tipo account
            Account acc = new Account(1001,"Alex",0.0);

            //Objeto do tipo BusinessAccount
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting & Polimorfismo

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003,"Bob",0.0,200.0);

            //DownCasting && Polimorfismo

            BusinessAccount bacc1 = (BusinessAccount) acc2;
            

        }
    }
}
