using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{
    internal class InheritanceParentDemo
    {
        public InheritanceParentDemo()
        {
            Console.WriteLine("I am in the parent class");
        }

        public void triggers()
        {
            Console.WriteLine("In parent -  the triggers function is invoked");
        }
    }

    internal class InheritanceChildDemo : InheritanceParentDemo 
    {
        public InheritanceChildDemo()
        {
            Console.WriteLine("I am in the child class");
        }
    }


    internal class InheritanceChildSubChildDemo : InheritanceChildDemo 
    {
        public InheritanceChildSubChildDemo()
        {
            Console.WriteLine("I am in the InheritanceChildSubChildDemo");
        }
    }
}
