using System;
using System.Globalization;

namespace Exercicio5
{
    class Program_Ex5
    {
        
        static void Main(string[] args)
        {
            int condigo,nPecas;
            float valorUni;
            float calculo,calculo2;

            string[] vec;

            Console.WriteLine("Digite as configuracoes da peca1");
            vec = Console.ReadLine().Split(' ');

            condigo = int.Parse(vec[0]);
            nPecas = int.Parse(vec[1]); 
            valorUni = float.Parse(vec[2],CultureInfo.InvariantCulture);

                calculo = nPecas * valorUni;

            Console.WriteLine("Digite as configuracoes da peca2");
            vec = Console.ReadLine().Split(' ');

            condigo = int.Parse(vec[0]);
            nPecas = int.Parse(vec[1]); 
            valorUni = float.Parse(vec[2],CultureInfo.InvariantCulture);

                calculo2 = nPecas * valorUni;

            Console.WriteLine("Valor a pagar: " + (calculo + calculo2).ToString("f2",CultureInfo.InvariantCulture));

        }
    }
}
