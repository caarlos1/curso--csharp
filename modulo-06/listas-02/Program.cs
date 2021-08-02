using System;
using System.Collections.Generic;

namespace listas_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Gato");
            lista.Add("Cachorro");
            lista.Add("Cavalo");
            lista.Insert(1, "Caramelo"); // É inserido, porém nao altera o indice 1.
            lista.Add("Cabrito");

            foreach (string animal in lista)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            Console.WriteLine("Tamanho da Lista: " + lista.Count);

            Console.WriteLine();

            string s1 = lista.Find(x => x[0] == 'C');
            Console.WriteLine("Primeiro com 'C': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'C');
            Console.WriteLine("Último com 'C': " + s2);

            int p1 = lista.FindIndex(x => x[0] == 'C');
            Console.WriteLine("Primeiro index 'C': " + p1);

            int p2 = lista.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Último index 'C': " + p2);

            Console.WriteLine();

            List<string> listaFiltrada = lista.FindAll(x => x.Length == 6);

            foreach (string item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // lista.Remove("Cavalo");
            lista.RemoveAt(3);

            foreach (string animal in lista)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            lista.RemoveAll(x => x[0] == 'G');

            foreach (string animal in lista)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            lista.RemoveRange(1, 2);

            foreach (string animal in lista)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
