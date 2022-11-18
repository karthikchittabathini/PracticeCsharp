using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Karthik", 14218);
            e.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
