using System;
using System.Globalization;

namespace Exercicio1
{
    class Program_Ex1
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo");

            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Esses sao os resultados do Retangulo: " + r);
        }
    }
}
