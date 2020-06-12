using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionario #{i}");
                Console.Write($"Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                lista.Add(new Funcionario(id, nome, salario));

            }          
            Console.WriteLine();

            Console.Write("Digite o ID do Funcionário que terá aumento salarial: ");
            int idPesquisa = int.Parse(Console.ReadLine());
            

            Funcionario func = lista.Find(x => x.Id == idPesquisa);
            if (func != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id informado não existe!");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            Console.WriteLine();

            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }        
        }
    }
}
