using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class CommandInterpreter : ICommandInterpreter
{
    private const string CommandSuffix = "Command";

    public CommandInterpreter(IHarvesterController harvesterController, IProviderController providerController)
    {
        this.HarvesterController = harvesterController;
        this.ProviderController = providerController;
    }

    public IHarvesterController HarvesterController { get; }

    public IProviderController ProviderController { get; }


    public string ProcessCommand(IList<string> args)
    {
        string commandName = args[0];
        string commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix;

        Type cmdType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(a => a.Name.Equals(commandCompleteName, StringComparison.InvariantCulture));

        var constructor = cmdType.GetConstructor(new Type[] { typeof(IList<string>) , typeof(IHarvesterController),typeof(IProviderController) });

        args = args.Skip(1).ToList();

        ICommand command = (ICommand)constructor.Invoke(new object[] { args,this.HarvesterController,this.ProviderController });

        return command.Execute();
    }
}

