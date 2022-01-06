using System;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //A variavel 'a' esta tendo uma referencia, assim podendo mudar o valor dela 
            Calculadora.Triple(ref a);
            Console.WriteLine(a);

            int triple;
            //Faz a mesma coisa que o 'ref' so que escolhe qual variavel vai receber o valor modificado
            Calculadora.Triplee(a,out triple);
            Console.WriteLine(triple);
        }
    }
}
