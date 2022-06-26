using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Sobreposicao.Entites
{
    class SavingsAccount_2 : Account_2
    {
        public double InterestRate { get; private set; }

        public SavingsAccount_2()
        {
        }

        public SavingsAccount_2(int number,string holder,double balance,double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; 
        }

        //Agora esse metodo sobrescrito da superclasse "Account_2" tem sua propria regra
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }

    }
}
