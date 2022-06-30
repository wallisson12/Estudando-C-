using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca_Ex1.Entites;

namespace Heranca_Ex1
{

    class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());

            for (int i =0;i<num;i++)
            {
                Console.WriteLine("Employee #" + i++);

                Console.Write("OutSource (y/n)?");
                char outS = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("ValuePerHour:");
                double valueP = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (outS == 'y')
                {

                    Console.Write("Additional Charge:");
                    double add = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee em_2 = new OutSourceEmployee(name, hours, valueP, add);

                    employees.Add(em_2);
                }
                else
                {
                    Employee em = new Employee(name, hours, valueP);

                    employees.Add(em);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Payment!");

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }

        }


        
    }
}
