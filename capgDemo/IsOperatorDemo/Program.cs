using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOperatorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsOperatorDemos iod = new IsOperatorDemos();
            Console.WriteLine(iod.ischecker());
            Console.ReadKey();
        }
        
    }
    public class IsOperatorDemos
    {
        string name = "karthik";
        public bool ischecker()
        {
            return name is string;
        }

    }
}
