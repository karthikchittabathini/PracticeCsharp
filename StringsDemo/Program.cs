using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = "karthik";
            string name2 = "chittabathini";
            string fullName = "karthik chittabathini";

            //both the writelines are same but are of different approaches
            Console.WriteLine(String.Format("name :- {0},\nsurname :- {1},\nfull name :- {2}", name, name2, fullName));
            Console.WriteLine($"name :- {name} \nsurname :- {name2} \nfullname :- {fullName}");

            //ToUppercase
            Console.WriteLine(name.ToUpper());
            Console.WriteLine("pichanayalaaa ".Trim());
            var fullNameArray = fullName.Split(' ');

            foreach( var Name in fullNameArray)
                Console.WriteLine(Name);
            Console.ReadLine();

        }
    }
}
