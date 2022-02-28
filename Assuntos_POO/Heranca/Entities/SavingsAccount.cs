using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        //O "base" serve para referenciar a superClasse assim utilizando o construtor de "Account",assim fazendo a reutilização de codigo.
        public SavingsAccount(int number, string holder, double balance,double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        //Metodos

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
