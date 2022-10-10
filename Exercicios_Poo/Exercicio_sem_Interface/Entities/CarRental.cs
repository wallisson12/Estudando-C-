using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_sem_Interface
{
    class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }
        public Vehicle Vehiclee { get;  set; }
        public Invoice Invoicee { get;  set; }

        public CarRental(DateTime start,DateTime finish,Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehiclee = vehicle;
            Invoicee = null;

        }

    }
}
