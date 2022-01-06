using System;

namespace matriz_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Instanciando a matriz
            int[,] mat = new int[n, n];

            for (int i=0;i<n;i++)
            {
                //Estou criando um vetor para armazenar os numeros digitados e separados por split
                string[] vec = Console.ReadLine().Split(' ');

                for (int j =0;j<n;j++)
                {
                    //Colocando os dados na matriz
                    mat[i, j] = int.Parse(vec[j]);
                }
            }


            //É onde a posição da linha e coluna sao iguais
            Console.Write("Main Diagonal: ");

            for (int i=0;i<n;i++)
            {
                Console.WriteLine(mat[i,i] + " ");
            }


            //Poderia utilizar dois 'for', mas o foreach fica mais simplificado
            Console.Write("Negative Numbers: ");
            int count =0;

            foreach (int obj in mat)
            {
                if (obj < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);


        }
    }
}
