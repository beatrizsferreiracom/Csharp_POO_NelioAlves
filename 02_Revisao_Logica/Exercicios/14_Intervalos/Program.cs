using System;
using System.Globalization;

namespace Intervalos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x >= 0 && x <= 25)
                Console.WriteLine("Intervalo [0, 25]");
            else if (x <= 50)
                Console.WriteLine("Intervalo [25, 50]");
            else if (x <= 75)
                Console.WriteLine("Intervalo [50, 75]");
            else if (x <= 100)
                Console.WriteLine("Intervalo [75, 100]");
            else
                Console.WriteLine("Fora de intervalo");
        }
    }
}