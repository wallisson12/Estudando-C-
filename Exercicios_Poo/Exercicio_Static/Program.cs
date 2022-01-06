using System;
using System.Globalization;

namespace Exercicio_Static
{
    class Program_Static
    {
        static void Main(string[] args)
        {
            double cotacao;
            double valor;

            Console.WriteLine("Qual e a contacao do dolar atual");
            cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai comprar");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + 
            ConversorDolarReal.Conversor(cotacao,valor).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
