using System;
using System.Globalization;

namespace Loja
{
  class Program
  {
    static void Main(string[] args)
    {
      Produto produto;
      produto = new Produto("Panela de Pressão", 155.40, 1);

      produto.Nome = "P"; // Não irá aceitar.
      Console.WriteLine($"Dados do produto: {produto} ");
    }
  }
}
