using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sempre deve fazer o for para cada situação
            // um for para somar, um pra imprimir, outro pra media e assim vai

            int N; // Número de elementos do vetor
            double soma, media; // Variáveis para soma e média
            double[] vet; // Vetor de números reais

            N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê o número de elementos do vetor
            vet = new double[N]; // Inicializa o vetor com o tamanho N
            soma = 0.0; // Inicializa a soma como 0.0

            string[] valores = Console.ReadLine().Split(' '); // Lê os valores do vetor como uma string e divide em partes

            for (int i = 0; i < N; i++) // Loop para preencher o vetor
            {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture); // Converte cada parte da string para double
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " "); // Imprime o valor formatado com uma casa decimal
                soma += vet[i];// Adiciona o valor ao total da soma
            }

            Console.WriteLine(); // Pula linha
            media = soma / N; // Calcula a média dos valores
            // Imprime a soma e a média formatadas com uma casa decimal
            Console.WriteLine("Soma: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
