using System;

namespace repeticao
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Quantos números quer digitar? Digite: ");
      int numerosParaDigitar = int.Parse(Console.ReadLine());
      double somaFinal = 0;

      for (var i = 1; i <= numerosParaDigitar; i++)
      {
        Console.Write($"Valor #{i}: ");
        double numeroDigitado = double.Parse(Console.ReadLine());
        somaFinal += numeroDigitado;
      }
      Console.WriteLine($"Soma: {somaFinal}");
    }
  }
}
