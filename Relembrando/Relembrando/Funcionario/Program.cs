using System;
using System.Collections.Generic;
using System.Globalization;
using Funcionario.Entites;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a lista de empregados
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            
            //Pegando as informacoes dos empregados
            for (int i=1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);

                Console.Write("Outsource ( Y / N ) ?");
                string c = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hour: ");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("ValuePerHour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Verificacao de empregado normal ou tercerizado
                if (c == "Y")
                {
                    Console.Write("AdditionalCharge: ");
                    double add = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    OutSourceEmployee outSource = new OutSourceEmployee(name,hour,valuePerHour,add);

                    employees.Add(outSource);
                }
                else
                {

                    Employee employee = new Employee(name, hour, valuePerHour);

                    employees.Add(employee);

                }


            }

            //Imprimindo os empregados e seus pagamentos
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee em in employees)
            {
                Console.WriteLine(em.Name + " - " + " $ " + em.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
