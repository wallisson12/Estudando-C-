using System;
using Exercicio2_Exception.Entites.Exceptions;

namespace Exercicio2_Exception.Entites
{
    class Account
    {
        private int _number;
        private string _holder;
        private double _balance;
        private double _withDrawLimit;

        public double Balance
        {
            get { return _balance; }
        }

        public Account(int number,string holder,double balance,double withDarwLimit)
        {
            _number = number;
            _holder = holder;
            _balance = balance;
            _withDrawLimit = withDarwLimit;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (_withDrawLimit < amount)
            {
                throw new DomainException("WithDraw Error: The amount must be less than withDrawLimit");
            }

            if (_balance < amount)
            {
                throw new DomainException("WithDraw Error: You don´t have enough balance");
            }

            _balance -= amount;
        }
    }
}
