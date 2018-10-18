using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Mission : IMission
{
    public Mission(double enduranceRequired)
    {
        this.EnduranceRequired = enduranceRequired;
    }
    public double EnduranceRequired { get; private set; }
    public IEnumerable<IAmmunition> MissionWeapons { get; internal set; }
    public string Name { get; private set; }

    public double ScoreToComplete { get; private set; }

    public double WearLevelDecrement { get; private set; }
}

