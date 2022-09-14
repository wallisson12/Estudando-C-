using System;
using Excecao_Personalizada.Entites;
using Excecao_Personalizada.Entites.Exceptions;

namespace Excecao_Personalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                //Ja faz a verificacao/validacao no proprio construtor
                Reservation reservation = new Reservation(number,checkIn,checkOut);

                Console.WriteLine("Reservation: " + reservation);


                Console.WriteLine();


                Console.WriteLine("Enter date to update the reservation: ");


                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                //Ja esta verificando/validando no proprio metodo da classe
                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                //Excecao personalizada 
                Console.WriteLine("Erro in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                //Excecao do sistema
                Console.WriteLine("Format error: " + e.Message);
            }

        }
    }
}
