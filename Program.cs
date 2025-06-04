using Problema2;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criamos o gerenciador que controla os quartos e alunos
        GerenciadorDeQuartos gerenciador = new GerenciadorDeQuartos();

        Console.Write("Quantos alunos deseja registrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\n--- Cadastro do aluno {i + 1} ---");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Número do quarto (0 a 9): ");
            int quarto = int.Parse(Console.ReadLine());

            bool sucesso = gerenciador.RegistrarAluno(nome, email, quarto);

            // Se falhar, repete esse cadastro
            if (!sucesso)
            {
                Console.WriteLine("Tente novamente com dados diferentes.");
                i--; // decrementa para refazer essa iteração
            }
        }

        Console.WriteLine("\n--- Fim do cadastro. Agora você pode buscar alunos ---");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Buscar por nome");
            Console.WriteLine("2 - Buscar por email");
            Console.WriteLine("3 - Buscar por número do quarto");
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome: ");
                    string nomeBusca = Console.ReadLine();
                    gerenciador.BuscarPorNome(nomeBusca);
                    break;

                case "2":
                    Console.Write("Digite o email: ");
                    string emailBusca = Console.ReadLine();
                    gerenciador.BuscarPorEmail(emailBusca);
                    break;

                case "3":
                    Console.Write("Digite o número do quarto: ");
                    int quartoBusca = int.Parse(Console.ReadLine());
                    gerenciador.BuscarPorQuarto(quartoBusca);
                    break;

                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}