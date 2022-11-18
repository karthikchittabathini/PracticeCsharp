using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Normal way of doing stuff

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 17, 99, 100};

            var result = new List<int>();
            //find the even numbers greater than 5
            foreach (var x in numbers)
            {
                if(x > 1 && x %2 == 0)
                {
                    //Console.WriteLine(x);
                    result.Add(x);
                }
            }

            result.Sort();
            result.Reverse();

            //display the result
            foreach(var x in result)
            {
                Console.WriteLine(x);
            }

            */


            //Linq syntax
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 17, 99, 100 };

            var result = from n in numbers
                         where n >2 && n % 2 == 0
                         orderby n descending
                         select n;
            /*
            foreach (var n in result)
            { 
                Console.WriteLine(n);
            }
             */   
            
            var res = numbers.Where(x => x > 2).First();
            Console.WriteLine(res);

            
            Console.ReadLine();
        }
    }
}
