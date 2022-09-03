using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario.Entites
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutSourceEmployee()
        {
        }

        public OutSourceEmployee(string name,int hour,double valuePerHour,double add) : base(name,hour,valuePerHour)
        {
            AdditionalCharge = add;
        }

        //Sobreescrevendo o metodo da superclasse
        public override double Payment()
        {
            return base.Payment() + ( AdditionalCharge * 110/100 );
        }
    }
}
