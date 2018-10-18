using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PressureProvider : Provider
{
    private const int DurabilityValue = 300;
    private const int EnergyDevider = 2;

    public PressureProvider(int id, double energyOutput) : base(id, energyOutput)
    {
        this.Durability -= DurabilityValue;
        this.EnergyOutput /= EnergyDevider;
    }
}

