using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLocalVariableDemo
{
    internal class Program
    {
        static void Main()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 17 }; 
            long totalSum = 0;

            Parallel.For<long>(0, numbers.Length, () => 0, (j, loop, subtotal) =>
            {
                subtotal += numbers[j];
                return subtotal;
            },
                (z) => Interlocked.Add(ref totalSum, z)
            );

            Console.WriteLine("The total is {0:N0}", totalSum);
            Console.ReadKey();
        }
    }
}
