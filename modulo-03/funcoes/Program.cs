using System;

namespace funcoes
{
  class Funcoes
  {
    static void Main(string[] args)
    {
      double n1, n2, n3;
      System.Console.WriteLine("Vamos descobrir o número maior!");
      System.Console.Write("Digite um número: ");
      n1 = double.Parse(Console.ReadLine());
      System.Console.Write("Digite outro número: ");
      n2 = double.Parse(Console.ReadLine());
      System.Console.Write("Digite outro número: ");
      n3 = double.Parse(Console.ReadLine());

      double numeroMaior = encontrarNumeroMaior(n1, n2, n3);
      Console.WriteLine($"Número maior: {numeroMaior}");
    }
    static double encontrarNumeroMaior(double a, double b, double c)
    {
      double maior;
      if (a > b && a > c)
      {
        maior = a;
      }
      else if (b > c)
      {
        maior = b;
      }
      else
      {
        maior = c;
      }
      return maior;
    }
  }
}
