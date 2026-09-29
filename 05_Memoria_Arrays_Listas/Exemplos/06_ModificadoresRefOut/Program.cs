using System;

namespace ModificadoresRefOut
{
    class Program
    {
        // Ref e Out: Faz o parâmetro ser uma referência para a variável original

        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}