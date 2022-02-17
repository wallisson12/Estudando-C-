using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class Account
    {
        //Protected serve para um modo de encapsulamento que so é visivel na propria classe e nas suas subClasses
        public int Number { get; private set;}
        public string Holder { get; private set;}
        public double Balance { get; protected set;}

        //Construtores
        public Account()
        {
        }

        public Account(int number,string holder,double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Metodos
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
