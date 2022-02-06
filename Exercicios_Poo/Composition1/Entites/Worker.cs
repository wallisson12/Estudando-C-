using System;
using System.Collections.Generic;
using System.Text;
using Composition1.Entites.Enums;
using Composition1.Entites;

namespace Composition1.Entites
{
    class Worker
    {
        public string Name;
        public WorkLevel Level;
        public Double BaseSalary;
        public Departament Departament;
        public List<HourContract> Contract = new List<HourContract>();

        //Construtor
        public Worker()
        {
        }

        public Worker(Departament departament,string nome,WorkLevel level,double baseSalary)
        {
            Departament = departament;
            Name = nome;
            Level = level;
            BaseSalary = baseSalary;
        }

        //Metodos
        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            
            foreach (HourContract obj in Contract)
            {
                if (obj.Date.Year == year && obj.Date.Month == month)
                {
                    sum += obj.TotalValue();
                }
            }

            return sum;
        }

    }
}
