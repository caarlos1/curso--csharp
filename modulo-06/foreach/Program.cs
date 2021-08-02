using System;

namespace foreach_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Carlos", "Anna", "Juninho" };

            foreach (string nome in vetor)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
