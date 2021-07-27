using System;
using System.Globalization;

namespace vetores
{
  class Program
  {
    static void Main(string[] args)
    {
      int tamanhoVetor;
      double[] vetor;

      Console.Write("Número de dados: ");
      tamanhoVetor = int.Parse(Console.ReadLine());
      vetor = new double[tamanhoVetor];

      for (int i = 0; i < tamanhoVetor; i++)
      {
        Console.Write($"Insira o valor #{i + 1}: ");
        vetor[i] = double.Parse(Console.ReadLine());
      }

      double soma = 0.0;
      double media;

      for (int i = 0; i < vetor.Length; i++)
      {
        soma += vetor[i];
      }

      media = soma / tamanhoVetor;
      Console.WriteLine($"Valor da média: {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}
