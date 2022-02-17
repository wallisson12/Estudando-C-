using System;

namespace DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2000, 12, 8, 5, 13, 10 ,58,System.DateTimeKind.Local);
            DateTime d1 = new DateTime(2000, 12, 8, 5, 13, 10, 58, System.DateTimeKind.Utc);
            DateTime d2 = new DateTime(2000, 12, 8, 5, 13, 10, 58);

            Console.WriteLine("d: " + d);
            Console.WriteLine("d Kind: " + d.Kind);
            Console.WriteLine("d to Local Time: " + d.ToLocalTime());
            Console.WriteLine("d to Universal Time: " + d.ToUniversalTime());

            Console.WriteLine();


            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local Time: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Universal Time: " + d1.ToUniversalTime());

            Console.WriteLine();


            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local Time: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Universal Time: " + d2.ToUniversalTime());
        }
    }
}
