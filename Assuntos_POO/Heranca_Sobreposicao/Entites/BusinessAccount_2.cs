using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Sobreposicao.Entites
{
    class BusinessAccount_2 : Account_2
    {
        public double LoanLimit { get; private set; }

        public BusinessAccount_2()
        {
        }

        public BusinessAccount_2(int number,string holder,double balance,double loanLimit) : base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount<=LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
