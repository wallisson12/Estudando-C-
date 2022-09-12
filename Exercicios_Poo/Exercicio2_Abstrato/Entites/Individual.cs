using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio2_Abstrato.Entites
{
    class Individual : Contribuintes
    {
        private double _health;

        public Individual(string name,double anualIncome,double health) : base(name,anualIncome)
        {
            _health = health;
        }

        public override double TaxPaid()
        {
            if (_anual_Income < 20000)
            {
                return Calculate(0.15);
            }
            else
            {
                return Calculate(0.25);
            }
        }

        private double Calculate(double percentage)
        {
            
            if (_health > 0)
            {
                return (_anual_Income * percentage) - (_health * 0.5);
            }
            else
            {
                return (_anual_Income * percentage);
            }

        }
    }
}
