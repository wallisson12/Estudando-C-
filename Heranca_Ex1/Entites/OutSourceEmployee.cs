using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Ex1.Entites
{
    class OutSourceEmployee : Employee
    {
        public double AddCharge { get; private set; }

        public OutSourceEmployee()
        {
        }

        public OutSourceEmployee(string name,int hours,double valuePerHour,double add) : base(name,hours,valuePerHour)
        {
            AddCharge = add;
        }

        public override double Payment()
        {
            return base.Payment() + (AddCharge * 110 / 100);
        }
    }
}
