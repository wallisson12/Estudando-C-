
using System;

namespace Exercicio_sem_Interface
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour,double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
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

            double tax = _brazilTaxService.Tax(payment);

            car.Invoicee = new Invoice(payment,tax);
        }

    }
}
