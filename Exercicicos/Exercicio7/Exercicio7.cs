using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            
            Console.WriteLine("Digite tres numeros");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("O maior numero eh: " + Maior(n1,n2,n3));
            
        }


        //Declaração de função
         static int  Maior(int n1,int n2,int n3){

            int maior;
                
            if(n1 > n2 && n1 > n3)
            {
                maior = n1;

            }else if(n2 > n3)
            {
                maior = n2;
            }else
            {
                maior = n3;
            }

            return maior;
        }

    }
}
