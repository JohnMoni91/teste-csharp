using System;

namespace Banco
{
    internal class ContaBancaria
    {
        // Propriedade para armazenar o nome do titular da conta
        // 'private set' indica que só pode ser alterado dentro da própria classe
        public string Nome { get; private set; }

        // Propriedade para armazenar o número da agência
        public string Agencia { get; private set; }

        // Propriedade para armazenar o saldo da conta
        public double Saldo { get; private set; }

        // Construtor da classe, executado quando criamos uma nova conta
        // Inicializa nome, agência e saldo (inicialmente zero)
        public ContaBancaria(string nome, string agencia)
        {
            Nome = nome;
            Agencia = agencia;
            Saldo = 0.0;
        }

        // Método para depositar valor na conta
        public void Depositar(double valor)
        {
            if (valor <= 0) // Validação para não aceitar depósitos negativos ou zero
                throw new ArgumentException("O valor do depósito deve ser positivo.");

            Saldo += valor; // Adiciona o valor ao saldo atual
        }

        // Método para sacar valor da conta
        public void Sacar(double valor)
        {
            if (valor <= 0) // Validação para não aceitar saques negativos ou zero
                throw new ArgumentException("O valor do saque deve ser positivo.");

            if (valor > Saldo) // Validação para não permitir saque maior que o saldo
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");

            Saldo -= valor; // Subtrai o valor do saldo atual
        }

        // Método sobrescrito para retornar uma string formatada com os dados da conta
        // Override significa que substituímos o método ToString original da classe base Object
        public override string ToString()
        {
            return $"Titular: {Nome}, Agência: {Agencia}, Saldo: {Saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}