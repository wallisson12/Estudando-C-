using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio2_Abstrato.Entites
{
    class Company : Contribuintes 
    {
        private double _employeNumber;

        public Company(string name,double anualIncome,double employeNumber) : base(name,anualIncome)
        {
            _employeNumber = employeNumber;
        }

        public override double TaxPaid()
        {
            if (_employeNumber > 10)
            {
                return Calculate(0.14);
            }
            else
            {
                return Calculate(0.16);
            }
        }

        private double Calculate(double porcentage)
        {
            return _anual_Income * porcentage;
        }

    }
}
