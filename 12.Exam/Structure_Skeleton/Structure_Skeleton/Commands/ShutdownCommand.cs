﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ShutdownCommand : Command
{
    public ShutdownCommand(IList<string> arguments, IHarvesterController harvesterController, IProviderController providerController) : base(arguments, harvesterController, providerController)
    {
    }

    public override string Execute()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.ProviderController.TotalEnergyProduced}");
        sb.Append($"Total Mined Plumbus Ore: {this.HarvesterController.OreProduced}");

        return sb.ToString();
    }
}

