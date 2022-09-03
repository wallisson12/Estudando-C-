using System;
using System.Collections.Generic;
using System.Text;

namespace Relembrando.Entites
{
    class Account 
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        //Contrutor padrao
        public Account()
        {
        }

        //Construtor customizado
        public Account(int n,string s,double b)
        {
            Number = n;
            Holder = s;
            Balance = b;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5f;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
