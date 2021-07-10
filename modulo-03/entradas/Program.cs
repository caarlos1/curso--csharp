using System;

namespace entradas
{
  class Program
  {
    static void Main(string[] args)
    {
      // System.Console.Write("Diga qualquer coisa: ");
      // string frase = Console.ReadLine();
      // Console.WriteLine($"Você digitou: {frase}");

      // System.Console.Write("Escreva três frutas: ");
      // string palavras = Console.ReadLine();
      // string[] vet = palavras.Split(' ');

      // string a = vet[0];
      // string b = vet[1];
      // string c = vet[2];

      // System.Console.WriteLine(a);
      // System.Console.WriteLine(b);
      // System.Console.WriteLine(c);

      // System.Console.Write("Digite um número: ");
      // int n1 = int.Parse(System.Console.ReadLine()); 
      // System.Console.WriteLine($"Você digitou: {n1}");

      // System.Console.Write("Digite uma letra: ");
      // char ch = char.Parse(System.Console.ReadLine());
      // System.Console.WriteLine($"Você digitou: {ch}");

      // System.Console.Write("Digite um valor com vírgulas: ");
      // double n2 = double.Parse(System.Console.ReadLine());
      // System.Console.WriteLine($"Você digitou: {n2}");

      System.Console.Write("Digite (nome, sexo, idade, altura): ");
      string[] linha = System.Console.ReadLine().Split(' ');

      string nome = linha[0];
      char sexo = char.Parse(linha[1]);
      int idade = int.Parse(linha[2]);
      double altura = double.Parse(linha[3]);

      System.Console.WriteLine($"Nome: {nome}");
      System.Console.WriteLine($"Sexo: {sexo}");
      System.Console.WriteLine($"Idade: {idade}");
      System.Console.WriteLine($"Altura: {altura}");
    }
  }
}
