using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_Abstrato.Entites
{
    abstract class Contribuintes 
    { 

        private string _name;
        protected double _anual_Income;

        public string Name 
        {
            get { return _name; }
        }
        public Contribuintes(string name, double anualIncome)
        {
            _name = name;
            _anual_Income = anualIncome;
        }

        public abstract double TaxPaid();

    }
}
