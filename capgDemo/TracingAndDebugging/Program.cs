using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TracingAndDebugging
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii, This was output written for console");
            Debug.WriteLine("in debug");
            Trace.WriteLine("in trace");

            Debug.WriteLineIf(true, "I was in debug writelineif");
            Trace.WriteLineIf(true, "I was in the trace writelineif");



            Console.ReadLine();
        }
    }
}
