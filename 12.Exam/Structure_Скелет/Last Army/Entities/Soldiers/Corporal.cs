using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Corporal : Soldier
{
    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "Helmet",
            "Knife"
        };
    public Corporal(IDictionary<string, IAmmunition> weapons, IReadOnlyList<string> weaponsAllowed) : base(weapons, weaponsAllowed)
    {
        this.OverallSkill = (this.Age + this.Experience) * 2.5;

    }

    public List<string> WeaponsAllowed1
    {
        get
        {
            return this.weaponsAllowed;
        }
    }

}

