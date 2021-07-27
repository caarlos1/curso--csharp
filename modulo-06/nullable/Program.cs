using System;

namespace nullable
{
  class Program
  {
    static void Main(string[] args)
    {
      double? x = null; // o "?" indica é nullable.
      Nullable<double> y = 10.0; // Forma mais verbosa.

      // GetValueOrDefault devolve o valor padrão do tipo ou o valor setado.
      Console.WriteLine(x.GetValueOrDefault());
      Console.WriteLine(y.GetValueOrDefault());

      Console.WriteLine(x.HasValue);
      Console.WriteLine(y.HasValue);

      if (x.HasValue)
        Console.WriteLine(x.Value);
      else
        Console.WriteLine("x é nulo");

      if (y.HasValue)
        Console.WriteLine(y.Value);
      else
        Console.WriteLine("y é nulo");


      Console.WriteLine("Testando o operador: ??");

      double? xx = null;
      double? yy = 10;

      double a = xx ?? 5;
      double b = yy ?? 5;

      Console.WriteLine(a);
      Console.WriteLine(b);

    }
  }
}
