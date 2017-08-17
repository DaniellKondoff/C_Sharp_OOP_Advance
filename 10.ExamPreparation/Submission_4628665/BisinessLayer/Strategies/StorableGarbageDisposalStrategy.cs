using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BisinessLayer.Strategies
{
    public class StorableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateCapitalbalance(IWaste garbage)
        {
            double capitalEarned = 0;
            double capitalUsed = garbage.CalculateWasteTotalVolume() * 0.65;

            return capitalEarned - capitalUsed;
        }

        protected override double CalculateEnergybalance(IWaste garbage)
        {
            double energyProduced = 0;
            double energyUsed = garbage.CalculateWasteTotalVolume() * 0.13;

            return energyProduced - energyUsed;
        }
    }
}
