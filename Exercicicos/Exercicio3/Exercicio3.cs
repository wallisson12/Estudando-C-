using System;

namespace Exercicio3
{
    class Program_Ex3
    {
        static void Main(string[] args)
        {
            int a, b, c, d,diferenca;

            Console.WriteLine("Digite os numeros: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("A diferenca entre o produtos dos numeros eh: " + diferenca);
        }
    }
}
