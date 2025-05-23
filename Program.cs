using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler
            // dois numeros inteiros M e N
            // Em seguida, ler uma matriz de M linhas e N colunas contendo números inteiros.
            // gerar um vetor de modo que cada elemento do vetor seja a soma dos elementos da linha correspondente da matriz.

            // Mostrar o vetor gerado.
            int m, n;
            int[,] soma;

            // Ler os valores de M e N
            string[] vet = Console.ReadLine().Split(' '); // Ler os valores de M e N
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);
            soma = new int[m, n]; // Criar a matriz de M linhas e N colunas

            for (int i = 0; i < m; i++) // Ler os valores da matriz
            {
                // Ler os valores da linha i da matriz
                // e armazenar na matriz soma
                // Exemplo: 1 2 3 4 5
                // soma[0,0] = 1, soma[0,1] = 2, soma[0,2] = 3, soma[0,3] = 4, soma[0,4] = 5
                {
                    vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    soma[i, j] = int.Parse(vet[j]);
                }
            }

            int[] somaLinhas = new int[m]; // Criar o vetor de soma das linhas

                for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    somaLinhas[i] += soma[i, j];
                }
            }

            for (int i = 0; i < m; i++) // Mostrar o vetor de soma das linhas
                {
                Console.WriteLine(somaLinhas[i]);
            }

            Console.ReadLine();
        }
    }
}
