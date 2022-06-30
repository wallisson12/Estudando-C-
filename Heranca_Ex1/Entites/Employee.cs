using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Ex1.Entites
{
    class Employee
    {
        public string Name { get; private set; }
        public int Hour { get; private set; }
        public double ValuePerHour { get; protected set; }

        public Employee()
        {
        }

        public Employee(string name,int hour,double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hour * ValuePerHour;
        }

    }
}
