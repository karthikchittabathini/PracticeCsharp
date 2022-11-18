using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    interface IAlexaHomeAssist
    {
        bool fan
        {
            get;set;
        }

        bool light
        {
            get; set;
        }
        void LightInformation(bool info);
        void FanInformation(bool info);
    }
}
