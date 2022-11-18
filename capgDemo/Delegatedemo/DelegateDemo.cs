using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatedemo
{
    public class DelegateDemo
    {

        public delegate int DelegateMultiply(int x, int y);
        public static DelegateMultiply delegateMultiply = new DelegateMultiply(DelegateDemo.Multiply);

        public static int Multiply(int x, int y)
        {
            return x * y;
        }



    }
}
