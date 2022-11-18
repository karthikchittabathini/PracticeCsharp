using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsoperatorDemo
{
    class Class1
    {
    }
    class Class2
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] myObjects = new object[6];
            myObjects[0] = new Class1();
            myObjects[1] = new Class2();
            myObjects[2] = "string";
            myObjects[3] = 32;
            myObjects[4] = null;
            for (int i = 0; i < myObjects.Length-1; ++i)
            {
                string s = myObjects[i] as string;
                Console.Write("{0} : ", i);
                if (s != null)
                    Console.WriteLine("  " + s + "  ");
                else
                    Console.WriteLine("This is not a string");
            }
            Console.ReadKey();
        }
    }
}
