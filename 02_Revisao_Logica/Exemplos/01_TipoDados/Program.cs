using System;

namespace TiposDados
{
    class Program
    {
        static void Main(string[] args)
        {

            // Números inteiros

            sbyte x = 127;
            Console.WriteLine(x);

            byte n1 = 255;
            Console.WriteLine(n1);

            int n2 = 1000;
            Console.WriteLine(n2);

            int n3 = 2147483647;
            Console.WriteLine(n3);

            long n4 = 2147483648L;
            Console.WriteLine(n4);

            // Números com ponto flutuante

            float n5 = 4.5f;
            Console.WriteLine(n5);

            double n6 = 4.5;
            Console.WriteLine(n6);

            // Valor Verdade
            bool completo = false;
            Console.WriteLine(completo);

            // Caracteres

            char genero = 'F';
            Console.WriteLine(genero);

            char letra = '\u0041';
            Console.WriteLine(letra);

            string nome = "Maria Green";
            Console.WriteLine(nome);

            object obj1 = "Alex Brown";
            Console.WriteLine(obj1);

            object obj2 = 4.5f;
            Console.WriteLine(obj2);

            // Mínimos e Máximos

            int n7 = int.MinValue;
            Console.WriteLine(n7);

            int n8 = int.MaxValue;
            Console.WriteLine(n8);

            sbyte n9 = sbyte.MinValue;
            Console.WriteLine(n9);

            decimal n10 = decimal.MaxValue;
            Console.WriteLine(n10);
        }
    }
}