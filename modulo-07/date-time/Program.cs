using System;
using System.Globalization;

namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2021, 8, 1);
            DateTime d2 = new DateTime(2021, 8, 1, 10, 58, 10);
            DateTime d3 = new DateTime(2021, 8, 1, 10, 58, 10, 500);

            // Console.WriteLine(d1.Ticks);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime p1 = DateTime.Parse("2000-08-15");
            DateTime p2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime p3 = DateTime.Parse("15/08/2000");
            DateTime p4 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime p5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime p6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine();
            Console.WriteLine(p5);
            Console.WriteLine(p6);
        }
    }
}
