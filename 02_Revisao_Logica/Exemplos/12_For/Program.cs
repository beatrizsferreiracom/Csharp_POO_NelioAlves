using System;
using System.Globalization;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}