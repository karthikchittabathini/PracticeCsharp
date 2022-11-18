using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{
    public class EncapsulationDemo
    {

        // 1st way 
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        //2nd way
        public string Organization { get; set; }
    }
}
