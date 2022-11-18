using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TostringAndEqualsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.ToString());
            c.EqualsDemo();
            c.TypeChecker();
            Console.ReadLine();
        }
    }
    public class Car
    {
        string model_no = "XUV700";
        string car_name = "Mahindra";


        
        public override string ToString()
        {
            return "the car was from " + car_name + " and it was " + model_no + " model";
        }

        
        public void EqualsDemo()
        {
            int a = 17;
            int b = 17;
            Console.WriteLine(a.Equals(b));


            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 71, 17 };
            Console.WriteLine(arr1.Equals(arr2));

            int[] arr3;
            arr3 = arr1;
            Console.WriteLine(arr3.Equals(arr1));

        }

        public void TypeChecker()
        {
            Typecheck ty = new Typecheck();
            Type type = ty.GetType();
            Console.WriteLine("Hiii, i am in type checker method and checking some stuff over here");
            Console.WriteLine(type.ToString());
            Console.WriteLine(type.IsClass);

        }

        

    }
    public class Typecheck
    {

    }
}
