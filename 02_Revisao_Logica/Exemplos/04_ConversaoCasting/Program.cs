using System;

namespace ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Conversão Implícita
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            // Casting
            double a;
            float b;

            a = 5.1;

            b = (float)a;
            Console.WriteLine(b);

            int c;

            c = (int)a;
            Console.WriteLine(c);

            int d = 5;
            int e = 2;

            double resultado = (double) d / e;
            Console.WriteLine(resultado);
        }
    }
}