using System;

namespace conversao
{
  class Program
  {
    static void Main(string[] args)
    {
      // Conversão implícita é quando um conteudo de um tipo pode 
      // ser naturamente ser atribuido para uma variavel de outro tipo.

      float x = 4.5f; // 4 bytes
      double y = x; // 8 bytes

      // Casting é uma conversão explícita entre tipos compatíveis.

      double a = 5.1;
      float b;
      int c;

      // Exemplos de casting.
      b = (float)a;
      c = (int)a;

      int valor1 = 5;
      int valor2 = 2;

      double resultado = (double)valor1 / valor2;

      System.Console.WriteLine(y);
      System.Console.WriteLine(b);
      System.Console.WriteLine(c);
      System.Console.WriteLine(resultado);
    }
  }
}
