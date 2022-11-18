using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsDemo
{
    public class Program
    {
        public static void display1()
        {
            Console.WriteLine("You are in static void method display1");
        }

        public static void display2(object name)
        {
            Console.WriteLine("You are in static void display2 parameterized method "+name);
        }
        public void display3()
        {
            Console.WriteLine("You are in method display3");
        }
        public void Dummy()
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(i);
            }
        }

        static readonly object router = new object();

        public static void Display()
        {
            lock (router)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("i value: {0}", i);
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {


            //string name = "Sweety";

            Program p = new Program();  
            Thread t1 = new Thread(new ThreadStart(display1));
            Thread t2 = new Thread(new ThreadStart(p.display3));
            Thread t3 = new Thread(new ParameterizedThreadStart(display2));
            Thread t4 = new Thread(new ThreadStart(p.Dummy));
            Thread t5 = new Thread(new ThreadStart(Display));


            t1.Start();
            t2.Start();
            t3.Start("karthik");
            t4.Start();
            t5.Start();


            //calling the method in which we used the lock
            Display();
            //calling the method in main method without any threads
            p.Dummy();
            display2("Neeraj");
            Console.ReadKey();

         }
    }
}
