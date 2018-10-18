using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ranker : Soldier
{
    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "Helmet"
        };
    public Ranker(IDictionary<string, IAmmunition> weapons, IReadOnlyList<string> weaponsAllowed) : base(weapons, weaponsAllowed)
    {
        this.OverallSkill = (this.Age + this.Experience) * 1.5;
    }

    public List<string> WeaponsAllowed1
    {
        get
        {
            return weaponsAllowed;
        }
    }

}

