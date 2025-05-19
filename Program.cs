using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course { 
    class Program
    {
        static void Main(string[] args)
        {
            // Entre com o seu nome completo 
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            // Quantos quartos tem na sua casa?
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qrtos = int.Parse(Console.ReadLine());

            // Entre com o preço de um produto
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Entre seu último nome, idade e altura (mesma linha):
            Console.WriteLine("Entre seu último nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // Mostrar resultado   
            Console.WriteLine(nome);
            Console.WriteLine(qrtos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}