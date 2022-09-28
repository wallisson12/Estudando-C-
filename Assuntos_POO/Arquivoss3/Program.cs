using System;
using System.IO;
namespace Arquivoss3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Teste\Texto1.txt";
            string targetPath = @"c:\Teste\Texto2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());

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
