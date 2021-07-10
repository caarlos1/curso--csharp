using System;

namespace exercicio_02
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.Write("Digite seu nome completo: ");
      string nomeCompleto = Console.ReadLine();

      System.Console.Write("Quantos quartos tem na sua casa: ");
      int quartos = int.Parse(Console.ReadLine());

      System.Console.Write("Digite o preço do produto: ");
      double precoProduto = double.Parse(Console.ReadLine());

      System.Console.Write("Digite seu último nome, idade e altura (mesa linha): ");
      string[] informacoesPessoa = Console.ReadLine().Split(' ');

      System.Console.WriteLine(nomeCompleto);
      System.Console.WriteLine(quartos);
      System.Console.WriteLine(precoProduto);

      System.Console.WriteLine(informacoesPessoa[0]);
      System.Console.WriteLine(int.Parse(informacoesPessoa[1]));
      System.Console.WriteLine(double.Parse(informacoesPessoa[2]));
    }
  }
}
