using System;
using System.Collections.Generic;

namespace Problema2
{
    // Classe que representa um aluno
    internal class Aluno
    {
        public string Nome { get; }
        public string Email { get; }
        public int Quarto { get; }

        public Aluno(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}, Email: {Email}, Quarto: {Quarto}");
        }
    }

    // Gerenciador dos quartos
    internal class GerenciadorDeQuartos
    {
        private Dictionary<int, Aluno> quartos; // quarto -> aluno

        public GerenciadorDeQuartos()
        {
            quartos = new Dictionary<int, Aluno>();
        }

        // Registra um aluno num quarto
        public bool RegistrarAluno(string nome, string email, int quarto)
        {
            if (quartos.ContainsKey(quarto))
            {
                Console.WriteLine($"O quarto {quarto} já está ocupado.");
                return false;
            }

            // Impede que alguém use o mesmo e-mail ou nome (opcional)
            foreach (var aluno in quartos.Values)
            {
                if (aluno.Nome == nome || aluno.Email == email)
                {
                    Console.WriteLine("Já existe um aluno com esse nome ou email.");
                    return false;
                }
            }

            Aluno novoAluno = new Aluno(nome, email, quarto);
            quartos[quarto] = novoAluno;
            Console.WriteLine($"Aluno registrado no quarto {quarto}.");
            return true;
        }

        // Buscar por nome
        public void BuscarPorNome(string nome)
        {
            foreach (var aluno in quartos.Values)
            {
                if (aluno.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    aluno.Exibir();
                    return;
                }
            }
            Console.WriteLine("Aluno não encontrado.");
        }

        // Buscar por email
        public void BuscarPorEmail(string email)
        {
            foreach (var aluno in quartos.Values)
            {
                if (aluno.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    aluno.Exibir();
                    return;
                }
            }
            Console.WriteLine("Aluno não encontrado.");
        }

        // Buscar por número do quarto
        public void BuscarPorQuarto(int quarto)
        {
            if (quartos.ContainsKey(quarto))
            {
                quartos[quarto].Exibir();
            }
            else
            {
                Console.WriteLine("Quarto vazio ou inexistente.");
            }
        }
    }

    // Main para testes
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeQuartos gerenciador = new GerenciadorDeQuartos();

            // Cadastrando alunos (exemplo)
            gerenciador.RegistrarAluno("Alice", "alice@email.com", 2);
            gerenciador.RegistrarAluno("Bob", "bob@email.com", 5);
            gerenciador.RegistrarAluno("Carlos", "carlos@email.com", 9);

            Console.WriteLine("\n-- Buscar por nome --");
            gerenciador.BuscarPorNome("Alice");

            Console.WriteLine("\n-- Buscar por email --");
            gerenciador.BuscarPorEmail("bob@email.com");

            Console.WriteLine("\n-- Buscar por quarto --");
            gerenciador.BuscarPorQuarto(9);
        }
    }
}
