using System;
using System.Globalization;

namespace Exercicio11
{
    class Program_E11
    {
        static void Main(string[] args)
        {
            //com Poo

            Triangulo x,y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");
             y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Formula para calcular

            double ax = x.Area();

            double ay = y.Area();


            Console.WriteLine("Area do triangulo X: " + ax.ToString("F4"));
            Console.WriteLine("Area do triangulo Y: " + ay.ToString("F4"));

            //Verifica qual o maior
            if(ax > ay){
                
                Console.WriteLine("Maior area: X");

            }else
            {
                Console.WriteLine("Maior area: Y");
            }

        }
    }
}
