using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedAndPositionalArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NamedArguments n = new NamedArguments();
            n.PersonDetails(name: "karthik", age: 20);
            n.PersonDetails("abc", 30);
            n.PersonDetails(age: 21, name: "neeraj");
            n.PersonDetails("abcd", age: 21);
            n.PersonDetails(name: "kavya", 22);

            OptionalArguments op = new OptionalArguments();
            Console.WriteLine(op.FullName("karthik"));
            Console.WriteLine(op.FullName("karthik", "chittabathini"));
            Console.WriteLine(op.FullName("karthik", "ch"));


            Console.Read();
        }
    }
    public class NamedArguments
    {
        string name;
        int age;

        public void PersonDetails(string name, int age)
        {
            Console.WriteLine("My name is " + name + " and i am " + age + " years old.");
        }
    }
    public class OptionalArguments
    {
        string first_name;
        string second_name;

        public string FullName(string firstname, String second_name= "bluff")
        {
            return firstname + second_name;
        }

    }
}
