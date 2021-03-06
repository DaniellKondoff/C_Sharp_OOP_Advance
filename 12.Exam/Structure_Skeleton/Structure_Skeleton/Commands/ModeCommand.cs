﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ModeCommand : Command
{
    public ModeCommand(IList<string> arguments, IHarvesterController harvesterController, IProviderController providerController) : base(arguments, harvesterController, providerController)
    {
    }

    public override string Execute()
    {
        var mode = this.Arguments[0];
 
        return $"Successfully changed working mode to {mode} Mode";
    }
}

