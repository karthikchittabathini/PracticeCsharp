using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate
{
    delegate void maindel(string info);
    public class Program
    {
        public static void Welcome(string s)
        {
            Console.WriteLine($" Welcome, {s}. ");
        }

        public static void Bye(string s)
        {
            Console.WriteLine($" Bye, {s}. ");
        }

        //working on func and action

        public delegate string upper(string s);
        static string UpperString(string s)
        {
            return  new string(s.ToUpper().ToArray());
        }

        static void UpperAndPrintInsideMethod(string s)
        {
            Console.WriteLine(new string(s.ToUpper().ToArray()));
        }


        static void Main(string[] args)
        {
            //working on Multi Delegate
            maindel hiDel, byeDel, multiDel;
            
            hiDel = Welcome;
            byeDel = Bye;
            multiDel = hiDel + byeDel;

            Console.WriteLine("Invoking the hiDel :- ");
            hiDel("karthik");
            Console.WriteLine("Invoking the byeDel :- ");
            byeDel("karthik");
            Console.WriteLine("Invoking the MultiDel :- ");
            multiDel("Carona Virus");


            //Working on func and action

            Console.WriteLine("using the delegate");
            upper up = UpperString;
            Console.WriteLine(up("karthik"));

            Console.WriteLine("Using the function");
            Func<string, string> up1 = UpperString;
            Console.WriteLine(up1("karthik"));

            Console.WriteLine("With the Action Delegate");
            Action<string> up2 = UpperAndPrintInsideMethod;

            Console.ReadLine();

        }
    }

}
