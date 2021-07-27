using System;
using System.Globalization;

namespace vetores
{
  class Program
  {
    static void Main(string[] args)
    {
      int quantidadeProdutos;
      Produto[] produtos;

      Console.Write("Número de produtos: ");
      quantidadeProdutos = int.Parse(Console.ReadLine());

      produtos = new Produto[quantidadeProdutos];

      for (int i = 0; i < quantidadeProdutos; i++)
      {
        Console.Write($"Insira o nome do produto #{i + 1}: ");
        string nome = Console.ReadLine();

        Console.Write($"Insira o valor do produto #{i + 1}: ");
        double preco = double.Parse(Console.ReadLine());

        produtos[i] = new Produto { Nome = nome, Preco = preco };
      }

      double soma = 0.0;
      for (int i = 0; i < produtos.Length; i++)
      {
        soma += produtos[i].Preco;
      }

      double media = soma / quantidadeProdutos;
      Console.WriteLine($"Preço médio dos produtos: {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}
