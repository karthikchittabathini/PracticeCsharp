using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GetpropertiesAndvalues
{
    public class Program
    {
        class Employee
        {
            public int salary { get; set; }
            public string name;
            public int EmpId;

            public bool isPermenentJob()
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Type t = typeof(Employee);
            GetFields(t);
            GetProperties(t);
            Console.ReadLine();

        }
        public static void GetFields(Type t)
        {
            Console.WriteLine("------ Fields -------");
            FieldInfo[] fi = t.GetFields();
            foreach( FieldInfo field in fi)
                Console.WriteLine(field.Name);
        }

        public static void GetProperties(Type t)
        {
            Console.WriteLine("------- Properties --------");
            PropertyInfo[] pi = t.GetProperties();
            foreach( PropertyInfo property in pi )
                Console.WriteLine(property.Name);
        }
    }
}
