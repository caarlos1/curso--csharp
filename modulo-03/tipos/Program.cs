using System;

namespace Tipos
{
  class Program
  {
    static void Main(string[] args)
    {
      // Tipos de dados.
      sbyte n1 = 100; // de -128 a 127
      byte n2 = 255; // de 0 a 255

      int n3 = 42;
      long n4 = 12018301394134914L; // o L é apenas uma recomendação
      float n5 = 4.5f;
      double n6 = 4.5;

      Console.WriteLine(n1);
      Console.WriteLine(n2);
      Console.WriteLine(n3);
      Console.WriteLine(n4);
      Console.WriteLine(n5);
      Console.WriteLine(n6);

      bool completo = false;
      char genero = 'F'; // usado ' para genero
      char letra = '\u0041';

      string nome = "Joaninha"; // usado " para string
      // OBS: string é imutavel *ainda não entendi*

      System.Console.WriteLine(completo);
      System.Console.WriteLine(genero);
      System.Console.WriteLine(letra);
      System.Console.WriteLine(nome);

      // object é um tipo genérico e pode 
      // ser atribuido varios tipos de valores.
      object obj1 = "Zezinho";
      object obj2 = 4.5f;

      System.Console.WriteLine(obj1);
      System.Console.WriteLine(obj2);

      int n01 = int.MinValue;
      int n02 = int.MaxValue;
      decimal n03 = decimal.MaxValue;

      System.Console.WriteLine(n01);
      System.Console.WriteLine(n02);
      System.Console.WriteLine(n03);
    }
  }
}
