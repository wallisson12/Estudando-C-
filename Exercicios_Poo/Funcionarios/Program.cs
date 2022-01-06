using System;
using System.Globalization;
using System.Collections.Generic;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many emloyees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> f = new List<Employee>();

            for (int i=0;i<n;i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //Instanciando o objeto e chamando o construtor
                f.Add(new Employee(id,name,salary));
            }


            Console.Write("Enter the employee id that will have salary increase: ");
            int valor = int.Parse(Console.ReadLine());

            Employee s1 = f.Find(x => x.Id == valor);

            if (s1 != null)
            {
                Console.Write("Enter the percentage: ");
                double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                s1.IncreaseSalary(porcent);
            }

            //Listando os elementos da lista
            foreach (Employee obj in f)
            {
                Console.WriteLine(obj);
            }


             
        }

       
    }
}
