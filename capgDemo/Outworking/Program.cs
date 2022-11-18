using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outworking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;

            OutUsage(out int i);
            Console.WriteLine(i);
            Console.ReadLine();
        }
        public static void OutUsage(out int x)
        {
            x = 100;
        }
    }
}
