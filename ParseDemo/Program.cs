using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            try
            {
                var num1 = int.Parse("abc");

            }
            catch (Exception)
            {

                Console.WriteLine("An error was occured");
            }

            int number;
            var num2 = int.TryParse("17", out number);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
