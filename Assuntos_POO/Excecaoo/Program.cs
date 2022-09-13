using System;

namespace Excecaoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estudando exceptions e como tratar elas com bloco TryCatch de um jeito personalizado

            //Caso o n2 seja 0 o programa vai lancar uma exception e quebra o programa a execucao

            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;

            Console.WriteLine(result);
            */


            //------------------------------------------------


            //Tratando com o bloco TryCatch

            try 
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                //Aqui faz o tratamento personalizado para cada excecao
                Console.WriteLine("Erro !!! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error !!! " + e.Message);
            }
           
            //O finaly executa independente se tiver ou nao alguma excecao

        }
    }
}
