﻿using System;

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