using System;
using System.Globalization;

namespace exercicio_01
{
  class Program
  {
    static void Main(string[] args)
    {
      string produto1 = "Computador";
      string produto2 = "Mesa de escritorio";
      string informacaoPreco = ", cujo preço é $ ";

      byte idade = 30;
      int codigo = 5290;
      char genero = 'M';

      double preco1 = 2100.0;
      double preco2 = 650.50;
      double medida = 53.234567;

      System.Console.WriteLine("Produtos:");
      System.Console.WriteLine($"{produto1}, cujo preco é $ {preco1:F2}");
      System.Console.WriteLine(produto2 + informacaoPreco + preco2.ToString("F2"));
      System.Console.WriteLine();
      System.Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
      System.Console.WriteLine();
      System.Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
      System.Console.WriteLine($"Medida com três casas decimais: {medida:F3}");
      System.Console.WriteLine($"Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    }
  }
}
