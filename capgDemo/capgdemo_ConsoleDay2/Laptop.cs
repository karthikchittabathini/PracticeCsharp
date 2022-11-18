using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgdemo_ConsoleDay2
{

    public class Laptop
    {

        public Laptop()
        {
            processor_name = "Intel";
            laptop_brandName = "HP";
            hasBackLightKeyBoard = true;
            generation = 9;
            Console.WriteLine("I am in the main parent laptop class");
        }

        public Laptop(string procName, string company, bool hasLight, int gen)
        {
            processor_name = procName;
            laptop_brandName = company;
            hasBackLightKeyBoard = hasLight;
            generation = gen;
        }

        public string processor_name;
        internal string laptop_brandName;
        protected bool hasBackLightKeyBoard;
        private int generation;
    

        public void DisplayDeatils()
        {
            Console.WriteLine("It is a " + laptop_brandName + " laptop consisting of " + processor_name + " processor with " + generation + " generation");
            if(hasBackLightKeyBoard)
            {
                Console.WriteLine("It has the feature of the backLightKeyBoard");
            }
            else
            {
                Console.WriteLine("It doesn't have the feature of backlight keyBoard");
            }
        }
    }

    class BrandNew : Laptop
    {

        public BrandNew()
        {
            Console.WriteLine("currently i am in the brand new sub class which is inherited from the parent class laptop");
        }
        public void OutputDetails()
        {
            Console.WriteLine("the values are checked accordingly to the priority of the access specifiers are " + laptop_brandName);
        } 
    }

}
