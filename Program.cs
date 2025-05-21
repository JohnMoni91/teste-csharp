using System;
using System.Globalization;


namespace Course{
    class Program{
        static void Main(string[] args)
        {
            // Preciso fazer um programa q leia um numero inderterminado de dados
            // contendo cada um, a idade de um individuo
            // o ultimo dado, q n entrara nos calculos, cotem um valor de idade negativa
            // calcular e imprimir a media de idade deste grupo
            // se houver idade negativa, o programa deve parar de ler os dados e imprimir q é impossivel calcular

            double idade, media;
            int cont = 0;

            Console.WriteLine("Digite a idade dos individuos: ");
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = 0.0;

            while (idade >= 0)
            {
                soma += idade;
                cont += 1;
                Console.WriteLine("Digite a idade dos individuos: ");
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine("A media de idade é: " + media.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
        }
    }
}
