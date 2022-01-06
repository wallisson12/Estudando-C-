using System;

namespace Exercicio1
{
    class Program_Ex
    {
        static void Main(string[] args)
        {
            //Somatorio de dois numeros

            int n1,n2,res;

            Console.WriteLine("Digite os numeros que deseja somar: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            res = n1 + n2;

            Console.WriteLine("O resultado de {0} e {1} eh {2}",n1,n2,res);

        }
    }
}
