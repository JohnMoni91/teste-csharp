using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeiroProjeto
{
    internal class Program2
    {

        static void Main(string[] args)
        {
            // trim é usado para remover espaços em branco no início e no final de uma string
            // ?? é usado para garantir que o valor lido não seja nulo, caso seja, será substituído por uma string vazia

            // Criação dos objetos Funcionario
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            // Leitura dos dados dos funcionários 
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.funcionario = (Console.ReadLine() ?? "").Trim();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine().Trim());

            // Leitura dos dados do segundo funcionário
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.funcionario = (Console.ReadLine() ?? "").Trim();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine().Trim());

            // Cálculo do salário médio
            double mediaSalario = (funcionario1.salario + funcionario2.salario) / 2.0;
            Console.WriteLine($"Salário médio = {mediaSalario:F2}");
        }
    }
}
