using System;
using System.Globalization;

namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t0 = new TimeSpan(0, 1, 30);

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // dias horas minutos segundos
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // ... milisegundos
            
            Console.WriteLine(t0);
            Console.WriteLine(t0.Ticks);

            Console.WriteLine();
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan ts1 = TimeSpan.FromDays(1.5);
            TimeSpan ts2 = TimeSpan.FromHours(1.5);
            TimeSpan ts3 = TimeSpan.FromMinutes(1.5);
            TimeSpan ts4 = TimeSpan.FromSeconds(1.5);
            TimeSpan ts5 = TimeSpan.FromMilliseconds(1);
            TimeSpan ts6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine();
            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(ts3);
            Console.WriteLine(ts4);
            Console.WriteLine(ts5);
            Console.WriteLine(ts6);
        }
    }
}
