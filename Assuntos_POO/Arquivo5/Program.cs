using System;
using System.IO;

namespace Arquivo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //A classe Path faz operacoes com caminhos

            string path = @"c:\Teste\SubPasta\aaa.txt";

            //Operacoes com path
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        }
    }
}
