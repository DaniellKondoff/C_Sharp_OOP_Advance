using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EnergyRepository : IEnergyRepository
{
    public double EnergyStored { get; }
    

    public void StoreEnergy(double energy)
    {
        //TODO
    }

    public bool TakeEnergy(double energyNeeded)
    {
        return false;//TODO
    }
}

