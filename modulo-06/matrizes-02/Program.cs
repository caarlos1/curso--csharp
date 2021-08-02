using System;

namespace matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int numeroNegativos = 0;
            string diagonalPrincipal = "";

            for (int l = 0; l < n; l++)
            {
                string[] colunas = Console.ReadLine().Split(' ');

                for (int c = 0; c < n; c++)
                {
                    int valorColuna = int.Parse(colunas[c]);
                    mat[l, c] = valorColuna;

                    if (valorColuna < 0)
                        numeroNegativos++;

                    if (l == c)
                        diagonalPrincipal = diagonalPrincipal + valorColuna.ToString() + " ";
                }
            }

            Console.WriteLine($"Diagonal principal: ");
            Console.WriteLine($"{ diagonalPrincipal }");

            Console.WriteLine($"Numeros negativos: {numeroNegativos}");
        }
    }
}
