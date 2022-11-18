using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{
    internal class PolymorphismDemo
    {
        // ---- polymorphism ------
        // one name many forms
        // divided into two types 
           // 1) static / compile time polymorphism
                // a) method overloading
                // b) operator overloading

           // 2) dynamic / run time polymorphism
                // a) method overriding


        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
