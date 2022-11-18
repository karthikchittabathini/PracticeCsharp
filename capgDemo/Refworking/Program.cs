using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refworking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            refUsage r = new refUsage();
            r.refdisplay();
            Console.Read();
        }
    }

    public class refUsage
    {
        int number = 100;
        public void refdisplay()
        {
            Console.WriteLine("The value of the number before ref usage = "+number);

            refImplementation(ref number);

            Console.WriteLine("The value of the same number after the ref usage = " + number);
        }

        public void refImplementation(ref int number)
        {
            number ++;
        }
    }
}
