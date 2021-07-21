using System;
using System.Globalization;

namespace Loja
{
  class Program
  {
    static void Main(string[] args)
    {
      Produto produto;
      produto = new Produto();

      Console.WriteLine("Entre com os dados do produto:");

      Console.Write("Nome: ");
      produto.Nome = Console.ReadLine();

      Console.Write("Preço: ");
      produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.Write("Quantidade: ");
      produto.Quantidade = int.Parse(Console.ReadLine());

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
