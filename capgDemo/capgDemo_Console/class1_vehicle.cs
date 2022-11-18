using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    internal class class1_vehicle
    {
        
        string color;
        string company_name;
        string model_name;

        public void display_details(string color, string company_name, string model_name)
        {
            Console.WriteLine("The bike name was " + company_name);
            Console.WriteLine("The model was "+ model_name + "and it was " + color);
        }
        
    }
}
