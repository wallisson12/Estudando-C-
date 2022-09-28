using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivoss4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"c:\Teste";

            try
            {
                //Colecao do c#
                //Lista as pastas no entanto pode listar os arquivos tbm
               IEnumerable<string> folder = Directory.EnumerateDirectories(Path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }

                //Criando uma pasta
                Directory.CreateDirectory(Path + "\\newFolder");

            }catch(IOException e)
            {
                Console.WriteLine("Erorr: " + e.Message);
            }
        }
    }
}
