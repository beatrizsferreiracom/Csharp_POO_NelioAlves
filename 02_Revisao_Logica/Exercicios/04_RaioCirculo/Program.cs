using System;
using System.Globalization;

namespace RaioCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, pi, area;

            pi = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (r * r);

            Console.WriteLine("ÁREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}