using System;

namespace QuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}