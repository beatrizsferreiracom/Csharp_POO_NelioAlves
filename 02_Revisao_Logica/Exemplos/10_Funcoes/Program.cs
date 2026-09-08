using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > 3)
                Console.WriteLine("Maior = " + n1);
            else if (n2 > n3)
                Console.WriteLine("Maior = " + n2);
            else
                Console.WriteLine("Maior = " + n3);

            Console.WriteLine("--------//--------");

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }
        static int Maior(int a, int b, int c)
        {
            int maior;
            if (a > b && a > c)
                maior = a;
            else if (b > c)
                maior = b;
            else
                maior = c;
            return maior;
        }
    }
}