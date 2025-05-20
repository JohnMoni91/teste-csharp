using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Course { 
    class Program
    {
        static void Main(string[] args)
        {
            // Preciso de um programa para ler as medidas da base e altura
            // Logo em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo. Com 4 casas decimais.
            double medBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // medida da base
            // Colocar um valor da base
            double medAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // medida da altura
            // colocar um valor da altura
            double area = medBase * medAltura; // área do retângulo
            // Para descobrir a área do retângulo, multiplica-se a base pela altura
            double perimetro = 2 * (medBase + medAltura); // perímetro do retângulo
            // Para descobrir o perímetro do retângulo, soma-se a base com a altura e multiplica-se por 2
            double diagonal = Math.Sqrt(Math.Pow(medBase, 2) + Math.Pow(medAltura, 2)); // diagonal do retângulo
            // Para descobrir a diagonal do retângulo, usa-se o Teorema de Pitágoras: a² + b² = c², onde c é a hipotenusa (diagonal)

            // Exibir os resultados com 4 casas decimais
            Console.WriteLine("Área: " + area.ToString("F4", CultureInfo.InvariantCulture)); // Exibir a área do retângulo com 4 casas decimais
            Console.WriteLine("Perímetro: " + perimetro.ToString("F4", CultureInfo.InvariantCulture)); // Exibir o perímetro do retângulo com 4 casas decimais
            Console.WriteLine("Diagonal: " + diagonal.ToString("F4", CultureInfo.InvariantCulture)); // Exibir a diagonal do retângulo com 4 casas decimais

        }
    }
}