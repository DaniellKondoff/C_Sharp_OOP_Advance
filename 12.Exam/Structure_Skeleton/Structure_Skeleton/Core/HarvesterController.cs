using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HarvesterController : IHarvesterController
{
    private IEnergyRepository energyRepository;
    private IList<IHarvester> harvesters;
    private IHarvesterFactory factory;
    public HarvesterController(IEnergyRepository energyRepository)
    {
        this.energyRepository = energyRepository;
        this.harvesters = new List<IHarvester>();
        this.factory = new HarvesterFactory();
    }
    public double OreProduced { get; }
   

    public string ChangeMode(string mode)
    {
        return null; //TODO
    }

    public string Produce()
    {
        return null;//TODO
    }

    public string Register(IList<string> args)
    {
        var harvester = this.factory.GenerateHarvester(args);
        this.harvesters.Add(harvester);
        return string.Format(Constants.SuccessfullRegistration,
            harvester.GetType().Name);
    }
}

