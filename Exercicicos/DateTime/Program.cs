using System;

namespace DateTimee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representa um instante
            DateTime d1 = DateTime.Now;

            //Tras a data de hoje as zero horas
            DateTime d4 = DateTime.Today;

            //Construtor, transforma o que você digitou em date time 
            DateTime d2 = new DateTime(1998,04,02); 
            DateTime d3 = new DateTime(1999, 12, 07, 20, 35, 15);

            //Ele aceita varios formatos
            DateTime d5 = DateTime.Parse("2000-08-04");
            DateTime d6 = DateTime.Parse("18/04/1995");
            DateTime d7 = DateTime.Parse("18/04/1995 13:15:56");

            //-----------------------------
            Console.WriteLine("DateTime: " + d1);
            Console.WriteLine("Ticks: " + d1.Ticks);
            Console.WriteLine("Today: " + d4);
            Console.WriteLine("DateTime Construtor1: " + d2);
            Console.WriteLine("DateTime Construtor2: " + d3);
            //----------------------------

            Console.WriteLine("Parse: " + d5);
            Console.WriteLine("Parse: " + d6);
            Console.WriteLine("Parse: " + d7);
        }
    }
}
