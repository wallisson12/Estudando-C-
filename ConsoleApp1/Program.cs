using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de lista
            List<string> nomes = new List<string>();

            nomes.Add("wallisson");
            nomes.Add("maria");
            nomes.Add("jose");
            nomes.Add("marco");
            nomes.Insert(2, "marcos");

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("List count: " + nomes.Count);

            Console.WriteLine("----------------------");

            //Expressao Lambda (função anonima) 
            string s1 = nomes.Find(x => x[0] == 'm');
            Console.WriteLine("frist m: " + s1);
            //tras o primeiro elemento que começa com a letra 'm'


            Console.WriteLine("----------------------");


            //tras o ultimo elemento que começa com a letra 'm'
            string s2 = nomes.FindLast(x => x[0]=='m');
            Console.WriteLine("last m: " + s2);


            Console.WriteLine("----------------------");

            //tras a posição do primeiro elemento que começa com a letra 'm'
            int pos1 = nomes.FindIndex(x => x[0] == 'm');
            Console.WriteLine("frist position m: " + pos1);

            Console.WriteLine("----------------------");

            //tras a posição do ultimo elemento que começa com a letra 'm'
            int pos2 = nomes.FindLastIndex(x => x[0] == 'm');
            Console.WriteLine("last position m: " + pos2);

            Console.WriteLine("----------------------");

            List<string> nomes2 = nomes.FindAll(x => x.Length == 5);

            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------");

            //remove um elemento da lista
            nomes.Remove("jose");

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------");

            //remove um elemento da lista com base na sua posição
            nomes.RemoveAt(2);

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------");

            //remove elementos de uma faixa (de posições)
            nomes.RemoveRange(1, 2);

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------");

            //remove um elemento da lista dependendo da logica do seu predicado(função anonima)
            nomes.RemoveAll(x => x[0] == 'w');

            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
