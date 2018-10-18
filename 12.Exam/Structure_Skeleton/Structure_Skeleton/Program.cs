using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {

        IDraftManager draftManager = new DraftManager();
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        IEnergyRepository energyRepository = new EnergyRepository();
        IHarvesterController harvesterController = new HarvesterController(energyRepository);
        IProviderController providerController = new ProviderController(energyRepository);
        ICommandInterpreter commandInterpreter = new CommandInterpreter(harvesterController,providerController);

        Engine engine = new Engine(draftManager,reader,writer, commandInterpreter);
        engine.Run();
    }
}