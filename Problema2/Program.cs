using Problema2;
using System.Globalization;
using System;

namespace Problemas
    {
    class Program
    {
        static void Main(string[] args)
        {
            // ler numero inteiro N e os dados (nome e preço) de N produtos
            int n = int.Parse(Console.ReadLine());
            
            Produtos[] produtos = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produtos(nome, preco);
            }
            // verificar se a quantidade de produtos é maior que zero antes de calcular
            if (produtos.Length > 0)
            {
                // calcular o preço
                double precoTotal = Produtos.CalcularPrecoTotal(produtos);
                Console.WriteLine($"Preço Total: {precoTotal:C}");

                // calcular a média
                double mediaPreco = Produtos.CalcularMediaPreco(produtos);
                Console.WriteLine($"Média de Preço: {mediaPreco:C}");
            }
        }
    }
};