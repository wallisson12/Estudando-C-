using System;
using System.Globalization;

namespace Exercicio2
{
    class Program_Ex2
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            double radius,area;

            Console.WriteLine("Calculo da area de um circulo ");

            Console.WriteLine("Digite o raio");

            radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = pi * (radius * radius);

            Console.WriteLine("A area do circulo com raio igual a {0} eh : {1}",radius,area.ToString("f4",CultureInfo.InvariantCulture));
        }
    }
}
