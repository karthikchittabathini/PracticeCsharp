using System;
using System.Collections.Generic;
using System.Linq;

namespace examsol
{
    internal class Program
    {

        public static List<int> getGreatestElements(List<int> arr, int k)
        {
            int n = arr.Count;
            
            int[] dummy = new int[n];
            List<int> ans = new List<int>(n);
            for(int i = k; i <= n; i++)
            {
                
                for(int j = 0; j < i; j++)
                {
                    dummy[j] = arr[j];
                    Console.WriteLine(dummy[j]);
                }
                Console.WriteLine("-------");
                Array.Reverse(dummy);
                //Console.WriteLine(dummy[k-1]);
                ans.Add(dummy[k - 1]);
            
            }


            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int k = 2;
            List<int> finalans = new List<int>();
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(4); // adding elements using add() method
            primeNumbers.Add(2);
            primeNumbers.Add(1);
            primeNumbers.Add(3);

            finalans = getGreatestElements(primeNumbers, k);

           // for (int i = 0; i < finalans.Count; i++)
              //  Console.WriteLine(finalans[i]);

            Console.ReadLine();
        }
    }
}
