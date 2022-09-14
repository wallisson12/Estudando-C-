using System;
using Excecao_Personalizada.Entites.Exceptions;

namespace Excecao_Personalizada.Entites
{
    class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber,DateTime checkIn,DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                //Lancando a excecao
                throw new DomainException("check-Out date must be after check-In");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //Pegando a duracao
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn,DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                //Exception personalizada
                //Lancando a exception do tipo "DomainException"
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkOut <= checkIn)
            {
               throw new DomainException("Check-Out date must be after CheckIn");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                   + RoomNumber
                   + ", check-in: "
                   + CheckIn.ToString("dd/MM/yyyy")
                   + ", check-out: "
                   + CheckOut.ToString("dd/MM/yyyy")
                   + ", "
                   + Duration()
                   + " nights";
        }
    }
}
