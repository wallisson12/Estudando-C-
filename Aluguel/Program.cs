using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {

            //Quantidade de quartos disponiveis
            RegistroA[] rooms = new RegistroA[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i =0;i<n;i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("E-mail: ");
                string em = Console.ReadLine();

                Console.Write("Room: ");
                int nq = int.Parse(Console.ReadLine());

                //Instanciando o obj
                rooms[nq] = new RegistroA { Nome = name, Email = em, Room = nq };
            }


            Console.WriteLine("Busy rooms: ");

            for (int i =0;i<10;i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i]);
                }
            }
        }
    }
}
