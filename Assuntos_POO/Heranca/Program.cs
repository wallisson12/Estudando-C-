using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "wallisson",0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "Alex", 0.0, 500.0);

            //UpCasting

            //Isso é possivel pq a hereança é uma relação "é um", ou seja o "bcc" é uma "Account".
            Account acc2 = bcc;

            //Na variavel do tipo "Account" tem um OBJ do tipo "BusinessAccount".
            Account acc3 = new BusinessAccount(1003,"Bob",0.0,200.0);
            Account acc4 = new SavingsAccount(1004,"Anna",0.0,0.01);

            //DownCasting

            //Possso fazer o casting utilizando o "as"
            BusinessAccount acc5 = acc3 as BusinessAccount;
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(100.0);

           // BusinessAccount acc7 = (BusinessAccount)acc4;

            //Verifico se o acc4 é uma instancia de BusinessAccount
            if (acc4 is BusinessAccount)
            {
                BusinessAccount acc6 = (BusinessAccount)acc4;
                acc6.Loan(200.0);
                Console.WriteLine("Loan!");

            }

            if (acc4 is SavingsAccount)
            {
                SavingsAccount acc7 = (SavingsAccount)acc4;
                acc7.UpdateBalance();
                Console.WriteLine("UpDate");
            }
        }
    }
}
