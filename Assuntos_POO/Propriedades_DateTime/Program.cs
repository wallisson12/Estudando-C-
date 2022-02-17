using System;

namespace Propriedades_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------Operacoes--------------------");

            DateTime da = DateTime.Now;

            DateTime d2 = da.AddDays(3);
            DateTime d3 = da.AddHours(1);
            DateTime d4 = da.AddMinutes(5);

            Console.WriteLine(da);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime d5 = new DateTime(2000,12,20);
            DateTime d6 = new DateTime(2000,12,25);

            TimeSpan t = d6.Subtract(d5);

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(t);

            Console.WriteLine("----------------------------------------");


            Console.WriteLine();


            DateTime d = new DateTime(2001,8,15, 15,30,45);


            Console.WriteLine("------------------Formatacoes-----------------");

            string s1 = d.ToLongDateString();
            Console.WriteLine(s1);

            string s2 = d.ToLongTimeString();
            Console.WriteLine(s2);

            string s3 = d.ToShortDateString();
            Console.WriteLine(s3);

            string s4 = d.ToShortTimeString();
            Console.WriteLine(s4);

            string s5 = d.ToString();
            Console.WriteLine(s5);

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss:fff");
            Console.WriteLine(s7);

            Console.WriteLine("---------------------------------------");


            Console.WriteLine();


            Console.WriteLine("----------------Propriedades------------");

            Console.WriteLine(d);
            Console.WriteLine("Date: " + d.Date);
            Console.WriteLine("Day: " + d.Day);
            Console.WriteLine("DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("DayOfYear: " + d.DayOfYear);
            Console.WriteLine("Hour: " + d.Hour);
            Console.WriteLine("Kind: " + d.Kind);
            Console.WriteLine("Milliseconds: " + d.Millisecond);
            Console.WriteLine("Seconds: " + d.Second);
            Console.WriteLine("Minute: " + d.Minute);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Ticks: " + d.Ticks);
            Console.WriteLine("TimeOfDay: " + d.TimeOfDay);

            Console.WriteLine("--------------------------------------------");
        }
    }
}
