using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario.Entites
{
    class Employee
    {

        public string Name { get; private set; }
        public int Hour { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee()
        {
        }

        //Construtor Customizado
        public Employee(string name,int hour,double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        //O virtual permite que o metodo seja sobreescrito em outra classe
        public virtual double Payment()
        {
            return Hour * ValuePerHour;
        }
    }
}
