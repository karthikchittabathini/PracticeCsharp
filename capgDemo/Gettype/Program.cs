using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettypeDemo
{
    /*
    class Student 
    {
        string name;
        int rollNo;

    }
    */
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            System.Type t = i.GetType();
            Console.WriteLine(t);
            Console.ReadLine();

            /*
            typemethodDemo1();
            typemethodDemo2();
            typemethodDemo3();
            Console.ReadLine();
        }

        static void typemethodDemo1()
        {
            Student s1 = new Student();
            Type t = s1.GetType();
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.AssemblyQualifiedName);
            Console.WriteLine(t.Assembly);
            

        }

        static void typemethodDemo2()
        {
            Type t = Type.GetType("gettypedemo.Student", false, true);
            Console.WriteLine(t.FullName);
        }
        
        static void typemethodDemo3()
        {
            Console.WriteLine((typeof(Student)).FullName);
        }
            */
        }
    }
}