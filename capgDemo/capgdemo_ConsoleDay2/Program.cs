using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgdemo_ConsoleDay2
{
    internal class Program
    {
        enum weekdays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }

        struct student
        {
            int student_id;
            string student_name;
        }

        static void Main(string[] args)
        {
            /*
            int a = 2147483647;
            Console.WriteLine("int "+a);

            long b = 922337203685477;
            Console.WriteLine("long "+b);

            long ab = a;
            Console.WriteLine("the long converted to int was "+ab);

            float f = 17.177777777753f;
            Console.WriteLine("float "+f);

            double d = 177.1777777777777777777345235237777777;
            Console.WriteLine("double "+d);

            byte byt = 255;
            Console.WriteLine("byte "+byt);

            short s = 1777;
            Console.WriteLine("short "+s);

            char chr = 'k';
            Console.WriteLine("char "+chr);

            bool ans = true;
            Console.WriteLine("bool " + ans);
            */
            /*
            sbyte sb = 1;
            while(sb < 127)
            {
                sb++;
                Console.WriteLine(sb);
            }
            Console.ReadKey();
            */

            //if (true)
            //{
            //    Console.WriteLine("here It was in the if loop");
            //}


            /*
            //infinite loop
            for(; ; )
            {
                Console.WriteLine("It was gone into a infinite for loop 😂");
            }
       
            Console.WriteLine("maximum value of a integer was "+ int.MaxValue);
            Console.WriteLine("maximum value of a byte was " + byte.MaxValue);


            String sentence = "Hii, i am karthik";
            Console.WriteLine(sentence);
            */
            /*
            Console.WriteLine((int)weekdays.Sunday);
            string today = Console.ReadLine();
            if(today == weekdays.Tuesday.ToString())
            {
                Console.WriteLine("Yes, your are correct today is "+today);
            }
            else
            {
                Console.WriteLine("No you are wrong today is "+weekdays.Tuesday);
            }
            */

            Laptop lappy1 = new Laptop();
            //lappy1.processor_name = "ryzen";
            //lappy1.laptop_brandName = "MSI";
            //lappy1.DisplayDeatils();


            //Laptop lappy2 = new Laptop("RYZEN", "lenovo", default, 5);
            //lappy2.DisplayDeatils();

            BrandNew leggy = new BrandNew();
            //leggy.OutputDetails();
           
            


            Console.ReadKey();

            
        }
    }
}
