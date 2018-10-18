using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class RegisterCommand : Command
{
    private const string ControllerSuffix = "Controller";
    public RegisterCommand(IList<string> arguments, IHarvesterController harvesterController, IProviderController providerController) : base(arguments, harvesterController, providerController)
    {
    }

    public override string Execute()
    {

        if (this.Arguments[0] == "Harvester")
        {
            return this.HarvesterController.Register(this.Arguments.Skip(1).ToList());
        }
        else
        {
            return this.ProviderController.Register(this.Arguments.Skip(1).ToList());
        }
    }
}

