using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegatesAndEvents
{
    public class Publisher
    {
        public delegate void IsliveEventHandler(object source, EventArgs args);
        public event IsliveEventHandler Islive;
        public void IsliveStarted()
        {
            Console.WriteLine("Starting the live");
            Thread.Sleep(5000);
            Onlive();
        }
        protected virtual void Onlive()
        {
            if(Islive != null)
            {
                Islive(this, EventArgs.Empty);
            }
        }
    }
}
