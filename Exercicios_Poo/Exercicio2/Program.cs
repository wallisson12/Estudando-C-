using System;
using System.Globalization;

namespace Exercicio2
{
    class Program_Ex2
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();

            Console.WriteLine("Digite as seguintes caixas de texto: ");

            Console.WriteLine("Name: ");
            f.Name = Console.ReadLine();

            Console.WriteLine("Salary_Bruto: ");
            f.Salary_B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 

            Console.WriteLine("Tribute: ");
            f.tribute = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(f);

            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para almentar o salario: ");
            double porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.IncreaseSalary(porc);

            Console.WriteLine();

            Console.WriteLine(f);
        }
    }
}
