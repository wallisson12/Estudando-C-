using System;
using System.Globalization;

namespace Exercicio3
{
    class Program_Ex
    {
        static void Main(string[] args)
        {
            Aluno a;
            a = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            a.Name = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(a);
        }
    }
}
