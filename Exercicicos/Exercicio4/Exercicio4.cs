using System;
using System.Globalization;

namespace teste
{
    class Program_Ex4
    {
        static void Main(string[] args)
        {
            int nFuncionarios,horas;
            float horasV,salario;

            Console.WriteLine("Digite o numero de funcionarios");
            nFuncionarios = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de horas trabalhadas");
            horas = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor que recebe por hora");
            horasV = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = horas * horasV;
            
            Console.WriteLine("Number = " + nFuncionarios);
            Console.WriteLine("Salary = " + salario.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
