using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override string ToString()
        {
            return $"{Nome}, {Preco:C}";
        }
        public static double CalcularPrecoTotal(Produtos[] produtos)
        {
            return produtos.Sum(p => p.Preco);
        }
        public static double CalcularMediaPreco(Produtos[] produtos)
        {
            return produtos.Average(p => p.Preco);
        }
    }
}
