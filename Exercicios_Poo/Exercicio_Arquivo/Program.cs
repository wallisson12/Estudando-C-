using Exercicio_Arquivo.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Exercicio_Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> product = new List<Product>();

            string sourcePath = @"c:\Teste\source.txt";
            string targetPath = @"c:\Teste\out\out2.txt";



            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {

                    foreach (string line in lines)
                    {
                        string[] l = line.Split(',');

                        string name = l[0];
                        double price = double.Parse(l[1],CultureInfo.InvariantCulture);
                        int amount = int.Parse(l[2]);

                        product.Add(new Product(name, price, amount));

                    }

                    foreach (Product p in product)
                    {
                        sw.WriteLine(p.Name + "," + p.Total().ToString("F2",CultureInfo.InvariantCulture));
                    }

                }
                

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
