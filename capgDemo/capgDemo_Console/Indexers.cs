using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    internal class Indexers
    {
        public int[] temperatures;
        public Indexers()
        {
            temperatures = new int[] { 17, 11, 77, 99, 100 };
        }
        public int this[int i]
        {
            get { return temperatures[i]; } 
            set { temperatures[i] = value;}
        }
    }
}
