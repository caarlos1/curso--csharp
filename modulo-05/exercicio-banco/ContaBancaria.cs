using System.Globalization;

namespace Banco
{
  public class ContaBancaria
  {
    public int Numero { get; private set; }
    public string Proprietario { get; private set; }
    public double Saldo { get; private set; }
    private double taxaDeSaque = 5;

    public ContaBancaria(int numero, string proprietario)
    {
      Numero = numero;
      Proprietario = proprietario;
    }

    public ContaBancaria(int numero, string proprietario, double depositoInicial) : this(numero, proprietario)
    {
      Depositar(depositoInicial);
    }

    public void Depositar(double valor)
    {
      if (valor > 0)
      {
        Saldo += valor;
      }
    }

    public void Sacar(double valor)
    {
      Saldo -= valor + taxaDeSaque;
    }

    public override string ToString()
    {
      return $"Conta { Numero }, Titular: { Proprietario }, Saldo: $ { Saldo.ToString("F2", CultureInfo.InvariantCulture) }";
    }
  }
}