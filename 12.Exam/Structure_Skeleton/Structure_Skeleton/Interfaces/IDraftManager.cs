using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IDraftManager
{
    string RegisterHarvester(List<string> arguments);
    string RegisterProvider(List<string> arguments);
    string Day();
    string Mode(List<string> arguments);
    string ShutDown();
    string Check(List<string> arguments);
}

