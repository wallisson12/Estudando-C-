using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de matriz
            int[,] numeros = new int[2,3];

            //Mostra o tamanho da matriz
            Console.WriteLine(numeros.Length);

            //Mostra a quantidade de dimensões na matriz
            Console.WriteLine(numeros.Rank);

            //Mostra a quantidade de linhas ou de colunas
            Console.WriteLine(numeros.GetLength(1));
        }
    }
}
