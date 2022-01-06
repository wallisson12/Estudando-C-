using System;
using System.Globalization;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            //Operação ternaria
            double desconto = (preco < 20.0 || preco > 100) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
