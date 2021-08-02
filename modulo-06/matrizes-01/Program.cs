using System;

namespace matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando matrizes bidimencionais.
            double[,] mat = new double[2, 3]; // [linhas, colunas]

            Console.WriteLine(mat.Length); // Elementos totais.
            Console.WriteLine(mat.Rank); // Número de linhas (Primeira Dimensão)

            Console.WriteLine(mat.GetLength(0)); // Primeira dimensão
            Console.WriteLine(mat.GetLength(1)); // Segunda dimensão
        }
    }
}
