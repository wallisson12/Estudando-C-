using System;
using System.Globalization;

namespace Exercicio13
{
    class Program_Ex13
    {
        static void Main(string[] args)
        {
            
            funcionario f1,f2;

            f1 = new funcionario();
            f2 = new funcionario();

            Console.WriteLine("Digite os dados do funcionario");

            Console.Write("Name: ");
            f1.name = Console.ReadLine();
            Console.Write("Salary: ");
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do proximo funcionario");

            Console.Write("Name: ");
            f2.name = Console.ReadLine();
            Console.Write("Salary: ");
            f2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) /2;

            Console.WriteLine("Salario medio eh: " + media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
