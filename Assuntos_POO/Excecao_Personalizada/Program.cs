using System;
using Excecao_Personalizada.Entites;

namespace Excecao_Personalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excecao personalizada de maneira errada sem o uso de tryCatch

            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro in reservation: Check-Out date must be after CheckIn");
            }
            else
            {
                Reservation reservation = new Reservation(number,checkIn,checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();


                Console.WriteLine("Enter date to update the reservation: ");


                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Erro in reservation dates for update must be future dates");
                }
                else if(checkOut <= checkIn)
                {
                    Console.WriteLine("Erro in reservation: Check-Out date must be after CheckIn");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }


        }
    }
}
