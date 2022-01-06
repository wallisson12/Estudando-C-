using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {   
        static void Main(string[] args)
        {
            string produto = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;



            Console.WriteLine("Produtos : ");
            Console.WriteLine("{0}, cujo preco eh $ {1}",produto,preco1.ToString("f2"));
            Console.WriteLine("{0}, cujo preco eh $ {1}",produto2,preco2.ToString("f2"));

            Console.WriteLine("");

            Console.WriteLine("Regristro: " + idade + " anos de idade, cujo codigo eh " + codigo + " e genero: " + genero );

            Console.WriteLine("");

            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("f8"));
            Console.WriteLine("Arredondando (tres casas decimais): " + medida.ToString("f3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("f3",CultureInfo.InvariantCulture));


        }
    }
}
