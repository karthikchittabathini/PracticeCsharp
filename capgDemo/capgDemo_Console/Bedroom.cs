using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    public class Bedroom : IAlexaHomeAssist
    {
        public bool fan { set; get; }
        public bool light { set; get; }
        public void LightInformation(bool info)
        {
            if (info)
            {
                Console.WriteLine("Light was in ON mode - bed room");
            }
            else
            {
                Console.WriteLine("Light was in OFF mode - bed room");
            }
        }

        public void FanInformation(bool info)
        {
            if (info)
            {
                Console.WriteLine("fan was in ON mode - bed room");
            }
            else
            {
                Console.WriteLine("fan was in OFF mode - bed room");
            }
        }
    }
}
