using System;
using System.Globalization;

namespace saidas
{
  class Program
  {
    static void Main(string[] args)
    {
      //   char genero = 'F';
      int idade = 32;
      double saldo = 10.12345;
      string nome = "Joaquim";

      // ToString converte em string e arredonda.
      // CultureInfo.InvariantCulture com que a ',' vire um '.'. 
      System.Console.WriteLine("Olha os dados das culturas: " + saldo.ToString("F4", CultureInfo.InvariantCulture));

      // Usando placeholder para montar saidas.
      System.Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2}.", nome, idade, saldo);
      System.Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2}.");
      System.Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2") + '.');
    }
  }
}
