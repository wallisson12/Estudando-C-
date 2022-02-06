using System;
using System.Collections.Generic;
using System.Text;

namespace Composition1.Entites
{
    class HourContract
    {
        public DateTime Date;
        public double ValuePerHour;
        public int Hours;


        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        //Retorna o valor das horas trabalhadas
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
