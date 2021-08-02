using System;
using System.Globalization;

namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 10, 15);
            DateTime d2 = d1.AddHours(2); // Existem vários Add...
            DateTime d3 = new DateTime(2000, 10, 18);

            TimeSpan ts = d3.Subtract(d1);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(ts);
        }
    }
}
