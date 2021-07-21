using System;
using System.Globalization;

namespace Loja
{
  public class Produto
  {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
      return Quantidade * Preco;
    }
    public void AdicionarProdutos(int quantidadeAdicionada)
    {
      Quantidade += quantidadeAdicionada;
    }
    public void RemoverProdutos(int quantidadeRemovida)
    {
      Quantidade -= quantidadeRemovida;
    }

    public override string ToString()
    {
      return $"{ Nome }, $ { Preco.ToString("F2", CultureInfo.InvariantCulture) }, { Quantidade } unidades, Total: $ { ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) }.";
    }
  }
}