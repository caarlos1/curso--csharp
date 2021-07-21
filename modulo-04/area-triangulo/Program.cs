using System;
using System.Globalization;

namespace area_triangulo
{
  class Program
  {
    static void Main(string[] args)
    {
      Triangulo x, y;
      x = new Triangulo();
      y = new Triangulo();

      Console.WriteLine("Entre com as medidas do Triângulo 1");
      x.A = double.Parse(Console.ReadLine());
      x.B = double.Parse(Console.ReadLine());
      x.C = double.Parse(Console.ReadLine());

      Console.WriteLine("Entre com as medidas do Triângulo 2");
      y.A = double.Parse(Console.ReadLine());
      y.B = double.Parse(Console.ReadLine());
      y.C = double.Parse(Console.ReadLine());

      Console.WriteLine("Área Triângulo 1: " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Área Triângulo 2: " + y.Area().ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
