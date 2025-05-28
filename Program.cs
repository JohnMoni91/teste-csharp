using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler os lados dos triangulos X e Y
            Console.WriteLine("Digite os lados do triangulo X: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite os lados do triangulo Y: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //formula de heron para calcular a area de um triangulo
            // valor de x
            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            // valor de y
            double q = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(q * (q - yA) * (q - yB) * (q - yC));


            // Exibir as areas
            Console.WriteLine($"Area X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            // Verificar qual area é maior
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");

            }
        }
    }
}