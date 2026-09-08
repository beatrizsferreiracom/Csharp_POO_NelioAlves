using System;
using System.Globalization;

namespace AreaFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;

            pi = 3.14159;

            string[] v = Console.ReadLine().Split();
            A = double.Parse(v[0], CultureInfo.InvariantCulture);
            B = double.Parse(v[1], CultureInfo.InvariantCulture);
            C = double.Parse(v[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;

            circulo = pi * C * C;

            trapezio = (A + B) / 2.0 * C;

            quadrado = B * B;

            retangulo = A * B;

            Console.WriteLine("TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}