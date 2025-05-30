using Banco; // Importa o namespace onde está a classe ContaBancaria
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pede o nome do titular da conta e lê a entrada do usuário
            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            // Pede o número da agência e lê a entrada do usuário
            Console.Write("Digite o número da agência: ");
            string agencia = Console.ReadLine();

            ContaBancaria conta; // Declara variável para armazenar a conta bancária criada

            // Pergunta se o usuário quer fazer um depósito inicial
            Console.Write("Deseja realizar um depósito inicial? (s/n): ");
            char resposta = char.ToLower(Console.ReadKey().KeyChar); // Lê a resposta e converte para minúscula

            if (resposta == 's')
            {
                // Se a resposta for sim, pede o valor do depósito inicial
                Console.Write("\nDigite o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Cria a conta com nome e agência
                conta = new ContaBancaria(nome, agencia);

                // Realiza o depósito inicial
                conta.Depositar(valorInicial);

                // Mostra mensagem confirmando a criação da conta com saldo inicial
                Console.WriteLine($"\nConta criada com sucesso! Saldo inicial: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                // Se não quiser depósito inicial, cria a conta com saldo zero
                conta = new ContaBancaria(nome, agencia);
                Console.WriteLine($"\nConta criada com sucesso! Saldo inicial: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            // Menu de operações que o usuário pode realizar na conta
            bool continuar = true; // Controla o loop do menu para continuar ou sair

            while (continuar) // Enquanto continuar for true, exibe o menu
            {
                Console.WriteLine("\nMenu de operações:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Exibir saldo");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = int.Parse(Console.ReadLine()); // Lê a opção escolhida pelo usuário

                switch (opcao) // Avalia a opção para executar a operação correta
                {
                    case 1: // Opção depósito
                        Console.Write("Digite o valor do depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Depositar(valorDeposito);
                        Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        break;

                    case 2: // Opção saque
                        Console.Write("Digite o valor do saque: ");
                        double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        try
                        {
                            conta.Sacar(valorSaque);
                            Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                        catch (Exception ex) // Tratamento de erro caso o saque não seja permitido
                        {
                            Console.WriteLine($"Erro ao realizar saque: {ex.Message}");
                        }
                        break;

                    case 3: // Exibir saldo atual
                        Console.WriteLine($"Saldo atual: {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
                        break;

                    case 4: // Sair do programa
                        continuar = false;
                        break;

                    default: // Caso a opção não seja válida
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}