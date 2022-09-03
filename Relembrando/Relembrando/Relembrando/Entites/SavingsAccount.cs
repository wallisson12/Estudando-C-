﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Relembrando.Entites
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number,string holder,double balance,double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2f;
        }
    }
}
