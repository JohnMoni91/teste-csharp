using System;
using System.Globalization;

namespace Course{
    class Program{
        static void Main(string[] args)
        {
            // Faça um programa que leia N números inteiros e armazene-os em um vetor. 
            // Em seguida, mostre na tela todos o números negativos lidos


            // primeiro tem q declarar a entrada e o vetor
            int N;
            int[] vet;

            // depois tem que ler o valor de N e inicializar o vetor com o tamanho N
            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] valores = Console.ReadLine().Split(' ');// lê os valores da linha e separa por espaço
            for (int i = 0; i < N; i++)
            {
                // converte os valores lidos para inteiro e armazena no vetor
                vet[i] = int.Parse(valores[i]);
            }

            for (int i = 0; i < N; i++)
            {
                // verifica se o valor é negativo e imprime na tela
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }


            Console.ReadLine();
        }
    }
}
