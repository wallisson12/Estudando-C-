
using System;

namespace Exercicio_sem_Interface
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Inversao de controle por meio de injecao de dependencia (Uns dos principios solid)
        private ITaxService _taxService; 

        public RentalService(double pricePerHour,double pricePerDay,ITaxService taxServicee)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxServicee;
        }

        public void ProcessInvoice(CarRental car)
        {
            TimeSpan duration = car.Finish.Subtract(car.Start);

            double payment = 0.0;

            if (duration.TotalHours <= 12)
            {
                payment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                payment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //Utilizando o servico
            double tax = _taxService.Tax(payment);

            car.Invoicee = new Invoice(payment,tax);
        }

    }
}
