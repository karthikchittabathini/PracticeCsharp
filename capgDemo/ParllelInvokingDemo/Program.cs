using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParllelInvokingDemo
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Parallel.Invoke(
                    FirstBasicAction,	
                    () =>			
                    {
                        Console.WriteLine("Method = B, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                    },
                    delegate ()		
                    {
                        Console.WriteLine("Method = C, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                    }
                );
            }
            catch (AggregateException e)
            {
                Console.WriteLine("An action has thrown an exception. THIS WAS UNEXPECTED.\n{0}", e.InnerException.ToString());
            }
            Console.Read();
        }

        static void FirstBasicAction()
        {
            Console.WriteLine("Method = A, Thread={0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
