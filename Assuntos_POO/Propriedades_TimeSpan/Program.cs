using System;

namespace Propriedades_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("-----------------");

            TimeSpan t5 = new TimeSpan(3, 5, 3, 50,11);
            Console.WriteLine(t5);

            Console.WriteLine("Days: " + t5.Days);
            Console.WriteLine("Hours: " + t5.Hours);
            Console.WriteLine("Minutes: " + t5.Minutes);
            Console.WriteLine("Seconds: " + t5.Seconds);
            Console.WriteLine("Miliseconds: " + t5.Milliseconds);

            Console.WriteLine("------------------");

            TimeSpan t = new TimeSpan(3, 10, 5);
            TimeSpan tt = new TimeSpan(0, 2, 5);

            TimeSpan sum = t.Add(tt);
            TimeSpan dif = t.Subtract(tt);
            TimeSpan mult = t.Multiply(2.0);
            TimeSpan div = tt.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
