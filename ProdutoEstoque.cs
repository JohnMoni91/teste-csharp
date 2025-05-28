using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class ProdutoEstoque
    {
        public string nome;
        public double preco;
        public int quantidade;
        public double ValorTotalEstoque()
        {
            return preco * quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }
        public override string ToString()
        {
            return $"{nome}, R$ {preco:F2}, {quantidade} unidades, Total: R$ {ValorTotalEstoque():F2}";
        }
    }
}
