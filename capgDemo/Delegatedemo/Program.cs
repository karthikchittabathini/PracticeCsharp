using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatedemo
{


    public class Program
    {

        public class demo
        {
            public static void display()
            {
                Console.WriteLine("You are in display method");
            }
            public static void Print()
            {
                Console.WriteLine("You are in Print method");
            }

            public void ShareInfo()
            {
                Console.WriteLine("You are in ShareInfo method");
            }
        }

        public delegate void delegateDisplay();
        static void Main(string[] args)
        {
            Console.WriteLine(DelegateDemo.Multiply(10, 17));
            Console.WriteLine(DelegateDemo.delegateMultiply(5, 10));

            delegateDisplay d1 = demo.display;

            delegateDisplay d2 = new delegateDisplay(demo.Print);

            demo dem = new demo();
            delegateDisplay d3 = dem.ShareInfo;

            d1();
            d2();
            d3();
            Console.ReadLine();
        }
    }
}
