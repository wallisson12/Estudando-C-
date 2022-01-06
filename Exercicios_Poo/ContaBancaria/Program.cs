using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program_Conta
    {
        static void Main(string[] args)
        {
            ContaBancaria con;

            Console.Write("Numero da conta: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular: ");
            string no = Console.ReadLine();

            Console.Write("Deseja fazer um deposito (s/n) ? ");
            char l = char.Parse(Console.ReadLine());

            if( l == 's' || l == 'S')
            {
                Console.Write("valor do deposito: ");
                double d = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                con = new ContaBancaria(c,no,d);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(con);

            }else
            {
                con = new ContaBancaria(c,no); 
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(con);
            }

            Console.Write("Valor deposito: ");
            double de = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            con.Deposito(de);

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(con);

            Console.Write("Valor Saque: ");
            double sa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            con.Saque(sa);
            
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(con);

        }
    }
}
