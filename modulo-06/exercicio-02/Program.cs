using System;
using System.Collections.Generic;

namespace exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listaDeEmpregados = new List<Employee>();

            Console.Write("Quantos empregados serão registrados? ");
            int numeroEmpregados = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= numeroEmpregados; i++)
            {

                Console.WriteLine($"Empregado #{i}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine());

                listaDeEmpregados.Add(
                    new Employee()
                    {
                        Id = id,
                        Name = name,
                        Salary = salary,
                    });
            }

            Console.WriteLine();
            Console.Write("Selecione o Id do usuário que receberá um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            bool empregadoExiste = listaDeEmpregados.Exists(x => x.Id == idAumento);

            if (empregadoExiste)
            {
                Console.Write("Porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());

                int indexEmpregado = listaDeEmpregados.FindIndex(empregado => empregado.Id == idAumento);
                listaDeEmpregados[indexEmpregado].IncreaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse usuário não existe.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista Atualizada dos Empregados:");

            foreach (Employee empregado in listaDeEmpregados)
            {
                Console.WriteLine($"{empregado.Id}, {empregado.Name}, {empregado.Salary}");
            }

        }
    }
}
