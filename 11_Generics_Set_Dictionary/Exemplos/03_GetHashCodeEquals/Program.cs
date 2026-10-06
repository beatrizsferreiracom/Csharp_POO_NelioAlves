using GetHashCodeEquals.Entities;
using System;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine();

            Client c = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client d = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(c.Equals(d));
            Console.WriteLine(a == b);
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
        }
    }
}