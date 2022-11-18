using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vartype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 100;
            Console.WriteLine(i);

            var name = "karthik";
            Console.WriteLine(name);

            dynamic j = 17;
            Console.WriteLine(j);
            Console.Read();
        }
    }
}
