using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            //using of the string builder
            //string builder is used to do a lot of manipulations to the string
            //This string builder is mutable
            //But string builder does not have the searching functionalities like strings
            //It misses the indexof , lastindexof, contains etc some functions
            //But it is used for the manipulation of the strings

            StringBuilder builder = new StringBuilder();
            builder.Append("Hiii, this is karthik")
                   .AppendLine("\n")
                   .Append('*', 17)
                   .Replace('*', '$');
            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
