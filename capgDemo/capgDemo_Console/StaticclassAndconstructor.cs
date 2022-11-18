using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    public static class StaticclassAndconstructor
    {
        
        public static string name = "karthik";
        public static void ItsAStaticMethod()
        {
            Console.WriteLine("Hiii, my name is " + name);
        }

        static StaticclassAndconstructor()
        {
            Console.WriteLine("It is a static Constructor");
        }
    }
}
