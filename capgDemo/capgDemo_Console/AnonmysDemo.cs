using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    public class AnonmysDemo
    {
        public void AnonymousDemo()
        {
            var k = new { name = "karthik", age = 21 };
            Console.WriteLine(k.name);
            Console.WriteLine(k.age);
        }
    }
}
