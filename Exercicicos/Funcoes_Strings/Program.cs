using System;

namespace Funcoes_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abc DEFG hij   ";

            //Deixa todas as strings como maiuscula
            string s1 = original.ToUpper();

            //Deixa todas as strings como minusculas
            string s2 = original.ToLower();

            //Retira todos os espaços em brancos, antes e depois das strings
            string s3 = original.Trim();

            //Serve para substituir um cahr ou string por outra
            string s4 = original.Replace('a','x');

            //Verifica se a string é nula ou está vazia
            bool b1 = string.IsNullOrEmpty(original);

            //Verifica se a string é nula ou tem espaço vazio(so que com varios espaços)
            bool b2 = string.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: " + "-" + original + "-");
            Console.WriteLine("ToUpper: " + "-" + s1 + "-");
            Console.WriteLine("ToLower: " + "-" + s2 + "-");
            Console.WriteLine("Trim: " + "-" + s3 + "-");
            Console.WriteLine("Replace: " + "-" + s4 + "-");

            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
