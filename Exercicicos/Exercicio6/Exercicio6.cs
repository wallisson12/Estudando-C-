using System;
using System.Globalization;

namespace Exercicio6
{
    class Program_Ex6
    {
        static void Main(string[] args)
        {
            string[] vec;
            double a,b,c;

            const double pi = 3.14159;
            double t,cr,tr,q,r;


            Console.WriteLine("Digite os tres valores");

            vec = Console.ReadLine().Split(' ');

            a = float.Parse(vec[0],CultureInfo.InvariantCulture);
            b = float.Parse(vec[1],CultureInfo.InvariantCulture);
            c = float.Parse(vec[2],CultureInfo.InvariantCulture);

            //Formulas
            t = (a*c)/2;
            cr = pi * (c*c);
            tr = (( a+b) * c)/2;
            q = b*b;
            r = a*b;

            Console.WriteLine("Triangulo: " + t.ToString("f3",CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + cr.ToString("f3",CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + tr.ToString("f3",CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + q.ToString("f3",CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + r.ToString("f3",CultureInfo.InvariantCulture));
        }
    }
}
