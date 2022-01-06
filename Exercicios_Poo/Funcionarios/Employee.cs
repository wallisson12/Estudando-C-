using System;
using System.Globalization;

namespace Funcionarios
{
    class Employee
    {
        public int Id { get; private set; }
        private string _name;
        private double Salary;


        public Employee(int id,string name,double salary)
        {
            Id = id;
            _name = name;
            Salary = salary;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage/100;
        }

        public override string ToString()
        {
            return Id + ", " + _name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
