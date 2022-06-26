using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Sobreposicao.Entites
{
    class Account_2
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account_2()
        {
        }

        public Account_2(int number,string holder,double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {

            Balance += amount;
        }
    }
}
