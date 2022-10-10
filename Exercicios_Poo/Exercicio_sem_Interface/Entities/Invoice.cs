﻿using System.Globalization;

namespace Exercicio_sem_Interface
{
    class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basicPayment,double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax; 
            }
        }


        public override string ToString()
        {
            return "BasicPayment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nTotal: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
