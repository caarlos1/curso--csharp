using System;

namespace matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimencoes = Console.ReadLine().Split(' ');

            int dimY = int.Parse(dimencoes[0]);
            int dimX = int.Parse(dimencoes[1]);

            int[,] matriz = new int[dimY, dimX];

            for (int linha = 0; linha < dimY; linha++)
            {
                string[] colunas = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < dimX; coluna++)
                {
                    int valorColuna = int.Parse(colunas[coluna]);
                    matriz[linha, coluna] = valorColuna;
                }
            }

            Console.WriteLine();
            Console.Write("Digite um número da matriz: ");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < dimY; linha++)
            {
                for (int coluna = 0; coluna < dimX; coluna++)
                {
                    if (matriz[linha, coluna] == numeroEscolhido)
                    {

                        Console.WriteLine();
                        Console.WriteLine($"Posição {linha},{coluna}:");

                        if (coluna - 1 >= 0)
                            Console.WriteLine($"Esquerda: {matriz[linha, (coluna - 1)]}");
                        if (coluna + 1 < dimX)
                            Console.WriteLine($"Direita: {matriz[linha, (coluna + 1)]}");
                        if (linha - 1 >= 0)
                            Console.WriteLine($"Topo: {matriz[(linha - 1), coluna]}");
                        if (linha + 1 < dimY)
                            Console.WriteLine($"Baixo: {matriz[(linha + 1), coluna]}");
                    }
                }
            }

        }
    }
}
