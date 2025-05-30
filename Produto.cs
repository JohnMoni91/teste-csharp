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


        // propriedade Nome com validação
        public string Nome // propriedade Nome com validação
        {
            get // Pega o valor do campo _nome
            {
                return _nome; // Retorna o nome do produto
            }
            set // Define o valor do campo _nome
            {
                if (value != null && value.Length > 1) // Verifica se o valor não é nulo e tem mais de um caractere
                {
                    _nome = value; // Se a validação passar, define o valor do campo _nome
                }
                else // Se a validação falhar
                {
                    throw new ArgumentException("Nome inválido. Deve ter mais de um caractere."); // Lança uma exceção com uma mensagem de erro
                }
            }
        }

        public double Preco
            {
                get
                {
                    return _preco;
                }
                set
                {
                    if (value >= 0)
                    {
                        _preco = value;
                    }
                    else
                    {
                        throw new ArgumentException("Preço inválido. Deve ser maior ou igual a zero.");
                    }
                }
            }

        public int Quantidade
            {
                get
                {
                    return _quantidade;
                }
                set
                {
                    if (value >= 0)
                    {
                        _quantidade = value;
                    }
                    else
                    {
                        throw new ArgumentException("Quantidade inválida. Deve ser maior ou igual a zero.");
                    }
                }
            }

    }
}