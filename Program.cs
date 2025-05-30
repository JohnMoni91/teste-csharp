using Produtos;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instancia o produto com nome, preço e quantidade
                Produto p = new Produto("TV", 500.00, 10);

                // Testa a alteração do nome
                p.Nome = "TV Nova";

                // Exibe os dados
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(p.Quantidade);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}