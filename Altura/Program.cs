using System;
using System.Globalization;

namespace Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;

            int n = int.Parse(Console.ReadLine());
            
            //Declaração de vetor(arry)
            double[] alturas = new double[n];

            for (int i =0;i<n;i++)
            {
                double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                alturas[i] = altura;
            }

            for (int i=0;i<n;i++)
            {
                media += alturas[i];
            }

            Console.WriteLine("Average Height = " + (media/n).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
