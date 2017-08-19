using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Assassin : AbstractHero
{
    private const int AssassinStrength = 25;
    private const int AssassinAgility = 100;
    private const int AssassinIntelligence = 15;
    private const int AssassinHitPoints = 150;
    private const int AssassinDamage = 300;
    public Assassin(string name) : base(name, AssassinStrength, AssassinAgility, AssassinIntelligence, AssassinHitPoints, AssassinDamage)
    {
    }
}

