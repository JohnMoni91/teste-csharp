using System;

namespace Produtos
{
    internal class Produto
    {
        // ================================
        // 1. Atributos privados
        // ================================

        // Campo privado para armazenar o nome (usado para validação personalizada)
        private string _nome;

        // Campos privados usados pelas propriedades com validação
        private double _preco;
        private int _quantidade;

        // ================================
        // 2. Propriedades autoimplementadas
        // ================================
        // (Neste caso, não temos nenhuma sem lógica interna, mas poderia ser por exemplo:
        // public string Categoria { get; set; }
        // )

        // ================================
        // 3. Construtores
        // ================================

        // Construtor padrão (sem parâmetros)
        public Produto()
        {
        }

        // Construtor com parâmetros (sobrecarga)
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;             // Usa o set de 'Nome', que já tem validação
            Preco = preco;           // Usa o set de 'Preco', com validação
            Quantidade = quantidade; // Usa o set de 'Quantidade', com validação
        }

        // ================================
        // 4. Propriedades customizadas
        // ================================

        // Propriedade personalizada com validação no set (usa o campo privado _nome)
        public string Nome
        {
            get => _nome;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    throw new ArgumentException("Nome inválido. Deve ter mais de um caractere.");
                }
            }
        }

        // Propriedade personalizada com validação no set (usa o campo privado _preco)
        public double Preco
        {
            get => _preco;
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

        // Propriedade personalizada com validação no set (usa o campo privado _quantidade)
        public int Quantidade
        {
            get => _quantidade;
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

        // ================================
        // 5. Outros métodos da classe
        // ================================
        // (Aqui você pode adicionar, por exemplo, métodos como:
        // - CalcularValorTotalEmEstoque()
        // - ToString()
        // etc.
        // )

    }
}