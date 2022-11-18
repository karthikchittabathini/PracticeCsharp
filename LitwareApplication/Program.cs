using System;
using LitwareLibrary;

namespace LitwareApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Litware!");
            Employee e1 = new Employee(17, "karthik", 40000);
            e1.CalculateSalary();
            Console.ReadLine();
        }
    }
}
