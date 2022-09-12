using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio2_Abstrato.Entites;

namespace Exercicio2_Abstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Contribuintes> contribuintes = new List<Contribuintes>();


            Console.Write("Enter the number of tax payers: ");
            int c = int.Parse(Console.ReadLine());

            for (int i=1;i <= c;i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Icome: ");
                double anual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Individual or Company (i/c): ");
                char pessoa = char.Parse(Console.ReadLine());


                if (pessoa == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuintes.Add(new Individual(name,anual,health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    contribuintes.Add(new Company(name,anual,employees));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Taxes Paid");

            double aux= 0;

            foreach (Contribuintes co in contribuintes)
            {
                Console.Write(co.Name + ": $ ");
                Console.WriteLine(co.TaxPaid().ToString("F2",CultureInfo.InvariantCulture));
                aux += co.TaxPaid();
            }

            Console.WriteLine();

            Console.WriteLine("Total Taxes: $ " + aux.ToString("F2",CultureInfo.InvariantCulture));
        }
    } 
}
