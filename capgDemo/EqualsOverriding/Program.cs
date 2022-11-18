using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualsOverridingCheck e = new EqualsOverridingCheck();
            e.BeforeOverriding();
            Console.ReadLine();
        }
    }
    public class EqualsOverridingCheck
    {
        int[] arr1 = new int[] { 17 };
        int[] arr2 = new int[] { 17 };
        public void BeforeOverriding()
        {
            if(arr1 == arr2)
            {
                Console.WriteLine("Yes, both the objects are equal");
            }
            else
            {
                Console.WriteLine("No, both the objects are not equal");

            }

            if (arr1.Equals(arr2))
            {
                Console.WriteLine("Yes, both the objects are equal");

            }
            else
            {
                Console.WriteLine("No, both the objects are not equal");

            }
        }

        public void afterOverriding()
        {

        }


    }
}
