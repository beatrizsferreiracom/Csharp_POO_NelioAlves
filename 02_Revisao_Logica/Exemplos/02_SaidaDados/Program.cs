using System;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write x Write Line
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine("---------//---------");

            // Impressão de variáveis
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("---------//---------");

            // Concatenação e interpolação

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", idade, saldo, nome);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo} reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}