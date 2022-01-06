using System;
using System.Globalization;

namespace Exercicio8
{
    class Program_Ex8
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce vai digitar?");
            int x = int.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);

            int soma = 0;

            for(int i = 1;i <= x;i++){

                Console.Write("valor #{0}: ",i );            
                int valor = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                soma += valor;
            }

                Console.WriteLine("Soma: {0}",soma);
        }
    }
}
