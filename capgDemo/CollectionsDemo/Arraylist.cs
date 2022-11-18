using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Arraylist
    {
        ArrayList arylist = new ArrayList();
        public void addcontentstoarraylist()
        {
            arylist.Add("karthik");
            arylist.Add(14218);
            arylist.Add("veltech college");

            foreach(var x in arylist)
            {
                Console.WriteLine(x);
            }

        }



    }
}
