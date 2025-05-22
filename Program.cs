using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro positivo N
            // depois ler N números inteiros e armazená-los em um vetor.

            int N;
            double[] vet; // Declaração do vetor de double

            N = int.Parse(Console.ReadLine());
            vet = new double[N]; // Cria o vetor com N posições

            for (int i = 0; i < N; i++) // i sempre inicia em 0 e vai até N-1
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê os números e armazena no vetor
            }

            for (int i = 0; i < N; i++) // i sempre inicia em 0 e vai até N-1
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture)); // Imprime os números do vetor com 2 casas decimais
            }
            Console.ReadLine();

        }
    }
}
