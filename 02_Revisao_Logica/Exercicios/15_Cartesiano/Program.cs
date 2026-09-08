using System;
using System.Globalization;

namespace Cartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else if (x == 0)
                Console.WriteLine("Eixo Y");
            else
                Console.WriteLine("Eixo X");
        }
    }
}