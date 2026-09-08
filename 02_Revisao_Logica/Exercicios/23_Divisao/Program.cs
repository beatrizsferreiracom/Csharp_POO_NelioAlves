using System;
using System.Globalization;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double divisao = (double)a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}