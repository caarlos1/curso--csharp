using System;

namespace ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b;
            Calculadora.Triplicar(ref a); // a == 30
            Calculadora.Quadriplicar(a, out b);
            Console.WriteLine(b); // b == 120

            // São um exemplo de code smell.
        }
    }
}
