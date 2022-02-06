using System;
using System.Globalization;
using Composition1.Entites;
using Composition1.Entites.Enums;

namespace Composition1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter departament´s name: ");
            string departament = Console.ReadLine();

            Console.WriteLine("Enter Work Data: ");

            Console.Write("Name: ");
            string nome = Console.ReadLine();

            Console.Write("Level (Junior/Mid_Level/Senior): ");
            WorkLevel level;
            Enum.TryParse(Console.ReadLine(), out level);
            

            Console.Write("Base Salary: ");
            double b_Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament depart = new Departament(departament);
            Worker worker = new Worker(depart,nome,level,b_Salario);

            Console.Write("How many contracts to this work? ");
            int contract = int.Parse(Console.ReadLine());

            int cont = 0;

            for (int i=0;i<contract;i++)
            {
                cont++;
                
                Console.WriteLine("Enter #" + cont + " contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contractt = new HourContract(data, value, duration);

                worker.AddContract(contractt);

            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate icome (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Level: " + worker.Level);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + " : " + worker.Income(year,month));
            

           
        }
    }
}
