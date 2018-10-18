using System.Collections.Generic;
using System.Text;


public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;
    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };

    public SpecialForce(IDictionary<string, IAmmunition> weapons, IReadOnlyList<string> weaponsAllowed)
        : base(weapons, weaponsAllowed)
    {
        this.OverallSkill = (this.Age + this.Experience) * 3.5;

    }

    public List<string> WeaponsAllowed1
    {
        get
        {
            return this.weaponsAllowed;
        }
    }
}
