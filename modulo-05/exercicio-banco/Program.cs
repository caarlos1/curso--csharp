using System;
using System.Globalization;

namespace Banco
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaBancaria contaBancaria;
      int conta;
      string propietario;
      double deposito = 0;

      Console.Write("Entre o número da conta: ");
      conta = int.Parse(Console.ReadLine());

      Console.Write("Entre o titular da conta: ");
      propietario = Console.ReadLine();

      Console.Write("Haverá deposito inicial? (s/n) ");
      char ahDeposito = char.Parse(Console.ReadLine());

      if (ahDeposito == 's')
      {
        Console.Write("Entre o valor de depósito inicial: ");
        deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        contaBancaria = new ContaBancaria(conta, propietario, deposito);
      }
      else
      {
        contaBancaria = new ContaBancaria(conta, propietario);
      }

      Console.WriteLine("Dados da conta:");
      Console.WriteLine(contaBancaria.ToString());

      Console.Write("Entre o valor de depósito: ");
      deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      contaBancaria.Depositar(deposito);

      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(contaBancaria.ToString());


      Console.Write("Entre o valor de saque: ");
      deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      contaBancaria.Sacar(deposito);

      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(contaBancaria.ToString());


    }
  }
}
