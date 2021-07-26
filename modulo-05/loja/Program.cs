using System;
using System.Globalization;

namespace Loja
{
  class Program
  {
    static void Main(string[] args)
    {
      Produto produto;
      Console.WriteLine("Entre com os dados do produto:");

      Console.Write("Nome: ");
      string nome = Console.ReadLine();

      Console.Write("Preço: ");
      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      produto = new Produto()
      {
        Nome = nome,
        Preco = preco,
        Quantidade = 0
      };


      Console.WriteLine($"Dados do produto: {produto} ");

      Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
      produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
      Console.WriteLine($"Dados atualizados: {produto} ");

      Console.Write("Digite o número de produtos a ser removido do estoque: ");
      produto.RemoverProdutos(int.Parse(Console.ReadLine()));
      Console.WriteLine($"Dados atualizados: {produto} ");


    }
  }
}
