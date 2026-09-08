using System;

namespace PostoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                    alcool = alcool + 1;
                else if (tipo == 2)
                    gasolina = gasolina + 1;
                else if (tipo == 3)
                    diesel = diesel + 1;

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}