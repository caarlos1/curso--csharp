using System;
using System.Globalization;

namespace membros_estaticos
{
  class Program
  {

    static void Main(string[] args)
    {
      double raio;

      Console.Write("Valor do raio: ");
      raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

    }

  }
}
