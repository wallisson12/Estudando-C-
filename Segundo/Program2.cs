using System;
using System.Globalization;

namespace Segundo
{
    class Program2
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            float preco;

            string[] vec;

            string nome2;
            int idade;
            float altura;


            Console.WriteLine("Entre com seu nome Completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto");
            preco = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome, idade e altura (na mesma linha)");
            vec = Console.ReadLine().Split(' ');

            nome2 = vec[0];
            idade = int.Parse(vec[1]);
            altura = float.Parse(vec[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("f2",CultureInfo.InvariantCulture));

            Console.WriteLine("");

            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
