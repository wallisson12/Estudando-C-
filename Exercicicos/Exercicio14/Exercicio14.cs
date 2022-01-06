using System;
using System.Globalization;

namespace Exercicio14
{
    class Program_Ex14
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv",500.00,5);

           p.Nome = "wallisson";
            
           Console.WriteLine(p.Nome);
           Console.WriteLine(p.Preco);
           Console.WriteLine(p.Quantidade);
        }
    }
}
