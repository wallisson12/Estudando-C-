using System;

namespace Exerciccios12
{
    class Program_Ex12
    {
        static void Main(string[] args)
        {
            //Criando duas variaveis do tipo da classe(pessoa)
            pessoa p1,p2;

            //Criando os objetos
            p1 = new pessoa();
            p2 = new pessoa();

            Console.WriteLine("Digite o nome e a idade");

            Console.Write("Name: ");
            p1.name = Console.ReadLine();
            Console.Write("Year: ");
            p1.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite os dados da segunda pessoa");

            Console.Write("Name: ");
            p2.name = Console.ReadLine();
            Console.Write("Year: ");
            p2.idade = int.Parse(Console.ReadLine());

            //Verificando a idade
            if(p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velha eh: " + p1.name + " com " + p1.idade + " years");

            }else
            {
                Console.WriteLine("A pessoa mais velha eh: " + p2.name + " com " + p2.idade + " years");
            }
        }
    }
}
