using System;
using System.IO;

namespace Arquivoss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utiliza o @ para não precisar utilizar duas barras para o caminho do arquivo
            string sourcePath = @"c:\Teste\Texto1.txt";

            string targetPath = @"c:\Teste\Texto2.txt";

            try
            {
                //Precisa de um caminho como parametro
                //Instanciando um objeto que vai estar associado a um arquivo em um determinado caminho
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);

                //Vai abir o arquivo nesse caminho e ler todas as linhas e colocalas no vetor
                //Cada linha vai ser um elemento do vetor
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines )
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
