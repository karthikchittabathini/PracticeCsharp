using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethodsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string college_name = "veltech";
            String hostel_name = "LeadersHostel";

            Console.WriteLine(college_name);

            Console.WriteLine(hostel_name.Contains("Hostel"));
            Console.WriteLine(hostel_name.EndsWith("ersHostel"));
            Console.WriteLine(hostel_name.StartsWith("Leaders"));

            Console.WriteLine(college_name.ToLower());
            Console.WriteLine(college_name.ToUpper());
            Console.WriteLine(college_name.IndexOf("e"));
            Console.WriteLine(college_name.LastIndexOf("e"));

            Console.WriteLine(hostel_name.Substring(0,hostel_name.Length).ToUpper());
            Console.WriteLine(college_name.Length);

            Console.Read();

        }
    }
}
