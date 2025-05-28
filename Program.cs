using PrimeiroProjeto;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // trim é usado para remover espaços em branco no início e no final de uma string
            // ?? é usado para garantir que o valor lido não seja nulo, caso seja, será substituído por uma string vazia

            // Cadastro
            Cadastro cadastro = new Cadastro();

            // cadastro da primeira pessoa
            cadastro.nome = (Console.ReadLine() ?? "").Trim();
            cadastro.idade = int.Parse(Console.ReadLine().Trim());

            // cadastro da segunda pessoa
            Cadastro cadastro2 = new Cadastro();

            // cadastro da segunda pessoa
            cadastro2.nome = (Console.ReadLine() ?? "").Trim();
            cadastro2.idade = int.Parse(Console.ReadLine().Trim());

            if (cadastro.idade < 0 && cadastro2.idade <0)
            {
                Console.WriteLine("Idade inválida");
            }
            else if (cadastro.nome == "" && cadastro2.nome == "")
            {
                Console.WriteLine("Nome inválido");
            }
            else
            {
                Console.WriteLine("Cadastro realizado com sucesso!");

                // Exibindo os dados cadastrados da primeira pessoa
                Console.WriteLine($"Nome da primeira pessoa: {cadastro.nome}");
                Console.WriteLine($"Idade da primeira pessoa: {cadastro.idade}");

                // Exibindo os dados cadastrados da segunda pessoa
                Console.WriteLine($"Nome da segunda pessoa: {cadastro2.nome}");
                Console.WriteLine($"Nome da segunda pessoa: {cadastro2.idade}");

            }
        }
    }
}