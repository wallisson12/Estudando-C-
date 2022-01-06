using System;
using System.Globalization;

namespace Exercicio10
{
    class Program_Ex10
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int cont2 = 0;

            Console.WriteLine("Digite os valores inteiros");
            int x = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            for(int i = 1;i<=x;i++){

                Console.WriteLine("Digite os valores");
                int valor = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                if(valor>=10 && valor<=20)
                {
                    cont++;

                }else
                {
                    cont2++;                    
                }
            }

            Console.WriteLine(cont + " in");
            Console.WriteLine(cont2 + " out");
            
        }
    }
}
