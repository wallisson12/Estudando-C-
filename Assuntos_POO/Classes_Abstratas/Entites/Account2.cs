using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas.Entites
{
    abstract class Account2
    {
        private int _number;
        private string _name;

        public Account2()
        {
        }

        public Account2(int number,string name)
        {
            _number = number;
            _name = name;
        }
    }
}
