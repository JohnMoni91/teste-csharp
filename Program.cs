using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        // Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida, mostrar o valor total do estoque (preço * quantidade) e permitir que o usuário informe quantos produtos serão adicionados ou removidos do estoque. Ao final, mostrar novamente o valor total do estoque.

        // puxar class do ProdutoEstoque.cs

        static void Main(string[] args)
        {
            // Declarando a outra classe
            ProdutoEstoque produto = new ProdutoEstoque();

            // Lendo os dados do produto
            Console.Write("Digite o nome do produto: ");
            produto.nome = Console.ReadLine() ?? "";

            //  Preço
            Console.Write("Digite o preço do produto: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Quantidade no estoque
            Console.Write("Digite a quantidade no estoque: ");
            produto.quantidade = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Valor total do estoque: R$ {produto.ValorTotalEstoque():F2}");

            // Adicionar e remover produtos do estoque
            Console.Write("Digite a quantidade de produtos a serem adicionados ao estoque: ");
            int quantidadeAdicionar = int.Parse(Console.ReadLine() ?? "0");
            produto.AdicionarProdutos(quantidadeAdicionar);
            Console.WriteLine($"Valor total do estoque após adição: R$ {produto.ValorTotalEstoque():F2}");
            Console.Write("Digite a quantidade de produtos a serem removidos do estoque: ");
            int quantidadeRemover = int.Parse(Console.ReadLine() ?? "0");
            produto.RemoverProdutos(quantidadeRemover);
            Console.WriteLine($"Valor total do estoque após remoção: R$ {produto.ValorTotalEstoque():F2}");

            Console.WriteLine(produto);
            Console.ReadLine();
        }
    }
}
