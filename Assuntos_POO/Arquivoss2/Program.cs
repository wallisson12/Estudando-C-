using System;
using System.IO;

namespace Arquivoss2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Teste\Texto1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //Abrindo o arquivo
                fs = new FileStream(path, FileMode.Open);

                //Fazendo a operacao com o arquivo
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();

                    Console.WriteLine(s);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Fechando as operacoes
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
