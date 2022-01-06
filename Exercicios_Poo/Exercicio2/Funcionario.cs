using System.Globalization;

namespace Exercicio2
{
    public class Funcionario
    {
        public string Name;
        public double Salary_B;
        public double tribute;

        public double SalaryLiqued(){

            return Salary_B - tribute;
        }

        public void IncreaseSalary(double percentage){

            Salary_B += (percentage/100f) * Salary_B;

        }


        public override string ToString()
        {
            return "Funcionario: " 
            + Name 
            +", $ " 
            + SalaryLiqued().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}