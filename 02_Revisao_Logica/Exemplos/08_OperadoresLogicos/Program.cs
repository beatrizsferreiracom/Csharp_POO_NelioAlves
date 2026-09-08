using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; // False
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5; // True
            Console.WriteLine(c2);

            bool c3 = !(2>3) && 4 != 5; // True
            Console.WriteLine(c3);

            bool c4 = 10 < 5; // False

            bool c5 = c2 || c3 && c4; // True
            Console.WriteLine(c5);
        }
    }
}