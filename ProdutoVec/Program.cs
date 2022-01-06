using System;
using System.Globalization;

namespace ProdutoVec
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaP = 0;

            int n = int.Parse(Console.ReadLine());

            //Criando vetor de produto
            ProdutoV[] p = new ProdutoV[n];

            for (int i =0;i<n;i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                //Instanciando o objeto
                p[i] = new ProdutoV { Nome = nome, Preco = preco };
            }

            for (int i=0;i<n;i++)
            {
                mediaP += p[i].Preco;
            }

            Console.WriteLine("Media de preco = " + (mediaP/4).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
