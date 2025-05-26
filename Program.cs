using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) atividade
            // Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            string[] produto = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(produto[0]);
            int numero1 = int.Parse(produto[1]);
            double valor1 = double.Parse(produto[2], CultureInfo.InvariantCulture);
            
            string[] produto2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(produto2[0]);
            int numero2 = int.Parse(produto2[1]);
            double valor2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);

            double  total = numero1 * valor1 + numero2 * valor2;
            Console.WriteLine("Valor a pagar: " + total);
            Console.ReadLine();

            // 1.2) atividade
            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            // casas decimais conforme exemplos. 
            // Fórmula: = area = π . raio2
            // Considere o valor de π = 3.14159.

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();

            // 2) atividade  
            //Com base na tabela de preços ao lado, faça
            //um programa que leia o código de um item e a
            //quantidade deste item. A seguir, calcule e
            //mostre o valor da conta a pagar.

            var cardapio = new Dictionary<int, double>()
            {
                { 1, 4.00 }, // Cachorro Quente
                { 2, 4.50 }, // X-Salada
                { 3, 5.00 }, // X-Bacon
                { 4, 2.00 }, // Torrada Simples
                { 5, 1.50 }  // Refrigerante
            };


            string[] pedidos = Console.ReadLine().Split(' ');
            int codigo = int.Parse(pedidos[0]);
            int quantidade = int.Parse(pedidos[1]);
            double valor = 0.0;

            if (cardapio.ContainsKey(codigo))
            {
                valor = cardapio[codigo] * quantidade;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }

            Console.ReadLine();

            // 2.2) atividade

            //Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau( + + = 0)
            //Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara(veja
            //abaixo).Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
            //negativo), mostrar uma mensagem "Impossivel calcular".

            string[] coeficientes = Console.ReadLine().Split(' ');
            double a = double.Parse(coeficientes[0], CultureInfo.InvariantCulture);
            double b = double.Parse(coeficientes[1], CultureInfo.InvariantCulture);
            double c = double.Parse(coeficientes[2], CultureInfo.InvariantCulture);

            double delta = b * b - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("R1 = " + raiz1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + raiz2.ToString("F5", CultureInfo.InvariantCulture));
            }

            //3) atividade

            // Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            // incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            // impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            int senhaCorreta = 2002;
            int senhaInformada; // Variável para armazenar a senha informada pelo usuário

            while (true) // Loop infinito até que a senha correta seja informada
            {
                senhaInformada = int.Parse(Console.ReadLine()); // Lê a senha informada pelo usuário
                if (senhaInformada == senhaCorreta) // Verifica se a senha informada é igual à senha correta
                {
                    Console.WriteLine("Acesso Permitido"); // Se for, imprime mensagem de acesso permitido
                    break; // Encerra o loop
                }
                else
                {
                    Console.WriteLine("Senha Invalida"); // Se não for, imprime mensagem de senha inválida
                }
            }

            Console.ReadLine();

            // 3.2) atividade
            // Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            // Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 

            int n = int.Parse(Console.ReadLine()); // Lê a quantidade de valores inteiros a serem lidos

            int dentroIntervalo = 0; // Contador para valores dentro do intervalo [10, 20]

            int foraIntervalo = 0; // Contador para valores fora do intervalo [10, 20]

            for (int i = 0; i < n; i++) // Loop para ler os valores inteiros
            {
                int x = int.Parse(Console.ReadLine()); // Lê o valor inteiro X
                if (x >= 10 && x <= 20) // Verifica se X está dentro do intervalo [10, 20]
                {
                    dentroIntervalo++; // Incrementa o contador de valores dentro do intervalo
                }
                else
                {
                    foraIntervalo++; // Incrementa o contador de valores fora do intervalo
                }
            }

        }
    }
}
