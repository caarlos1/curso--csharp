using System;
using System.Globalization;

namespace datas
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

            TimeSpan ts1 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(ts1);
            Console.WriteLine("Dias: " + ts1.Days);
        }
    }
}
