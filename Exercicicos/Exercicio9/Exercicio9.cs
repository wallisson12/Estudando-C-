using System;
using System.Globalization;

namespace Exercicio9
{
    class Program_Ex9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dige um valor inteiro");
            int x = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int valor =0;
            for(int i =1;i<=x;i++){

                valor = i % 2;

                if(valor != 0){

                    Console.WriteLine(i);
                }

            }
        }
    }
}
