using System;

namespace repeticao
{
  class Program
  {
    static void Main(string[] args)
    {
      double numeroDigitado = 0;
      while (numeroDigitado == 0 || numeroDigitado < 0)
      {
        Console.Write("Digite um número: ");
        numeroDigitado = double.Parse(Console.ReadLine());

        if (numeroDigitado <= 0)
        {
          Console.WriteLine("Erro! Número negativo ou igual a zero.");
        }
        else
        {
          double raizNumeroDigitado = Math.Sqrt(numeroDigitado);
          Console.WriteLine($"Raiz do número digitado: {raizNumeroDigitado:F3}");
        }
      }
    }
  }
}
