using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            //working with date and time
            var now = DateTime.Now;
            var now2 = DateTime.Now.AddDays(1);
            var now3 = now2 - now;


            //Console.WriteLine(now.Date);
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now3.Days);

            //working with time span
            var timespan1 = new TimeSpan(7, 17, 17);
            var timespan2 = timespan1.Add(TimeSpan.FromSeconds(1));
            Console.WriteLine(timespan1.ToString());
            var timespan3 = timespan2 - timespan1;
            Console.WriteLine(timespan2);
            Console.WriteLine(timespan3);
            Console.ReadLine();

        }
    }
}
