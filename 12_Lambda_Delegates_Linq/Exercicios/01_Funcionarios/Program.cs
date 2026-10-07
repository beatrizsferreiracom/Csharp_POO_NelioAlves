using Funcionarios.Entities;
using System;
using System.Globalization;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double refSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine();
                var emails = list.Where(e => e.Salary > refSalary).OrderBy(e => e.Email).Select(e => e.Email);

                Console.WriteLine($"Email of people whose salary is more than " + refSalary.ToString("F2", CultureInfo.InvariantCulture)+ ":");
                foreach (string e in emails)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine();
                var sum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}