using System;
using System.Globalization;

namespace IntervaloInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                    dentro += 1;
                else
                    fora += 1;
            }

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);
        }
    }
}