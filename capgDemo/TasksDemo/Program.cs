using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";

            Task task2 = new Task(() => Console.WriteLine("Hiii i am in task2"));
            task2.Start();

            Task task1 = Task.Run(() => Console.WriteLine("Hiii i am in task1"));

            Console.WriteLine("Hii, i am from console writeline in {0} method", Thread.CurrentThread.Name);

            Console.ReadLine();
        }
    }
}
