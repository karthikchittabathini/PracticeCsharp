using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    public class HallRoom : IAlexaHomeAssist
    {
        public bool fan { set; get; }
        public bool light { set; get; }

        public void LightInformation(bool info)
        {
            if (info)
            {
                Console.WriteLine("Light was in ON mode - hall room");
            }
            else
            {
                Console.WriteLine("Light was in OFF mode - hall room");
            }
        }

        public void FanInformation(bool info)
        {
            if (info)
            {
                Console.WriteLine("Fan was in ON mode - hall room");
            }
            else
            {
                Console.WriteLine(" Fan was in OFF mode  - hall room");
            }
        }
    }
}
