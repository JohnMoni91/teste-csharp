using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char continuar = 's';

            do
            {
                Console.Write("Digite a temperatura em celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja continuar? ");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's');

        }
    }
}
