using System;
using System.Globalization;
using Exercicio2_Exception.Entites;
using Exercicio2_Exception.Entites.Exceptions;

namespace Exercicio2_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("WithDraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, withDrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                account.WithDraw(amount);

                Console.Write("New balance: ");
                Console.Write(account.Balance.ToString("F2",CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException Error: " + e.Message);
            }
        }
    }
}
