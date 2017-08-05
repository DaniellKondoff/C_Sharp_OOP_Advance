using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWeapon
{
    void Attack(ITarget target);
    int AttackPoints { get; set; }
    int DurabilityPoints { get; set; }
}

