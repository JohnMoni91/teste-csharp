using System;

namespace Produtos
{
    internal class Produto
    {

        // Get é um método que retorna o valor de um campo ou propriedade.
        // Set é um método que define o valor de um campo ou propriedade.
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = _quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            else
            {
                throw new ArgumentException("Nome inválido. Deve ter mais de um caractere.");
            }

        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

    }
}