using System;

namespace exercicio_01
{
  class Program
  {
    static void Main(string[] args)
    {
      int numeroQuartos = 10;
      Hospede[] hospedes = new Hospede[numeroQuartos];

      Console.Write("Número de Quantos a serem alugados: ");
      int quartosAlugados = int.Parse(Console.ReadLine());

      for (int i = 0; i < quartosAlugados; i++)
      {
        Console.WriteLine($"Hospede #{i + 1}");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Quarto: ");
        int quarto = int.Parse(Console.ReadLine());

        hospedes[quarto] = new Hospede
        {
          Nome = nome,
          Email = email,
          Quarto = quarto,
        };
      }
      Console.WriteLine("Lista de Hospedes:");

      for (int i = 0; i < hospedes.Length; i++)
      {
        if (hospedes[i] != null)
          Console.WriteLine($"{ hospedes[i].Quarto }: { hospedes[i].Nome }, Email: { hospedes[i].Email } ");

      }
    }
  }
}
