using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BisinessLayer.Strategies
{
    public class RecycableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateCapitalbalance(IWaste garbage)
        {
            double capitalEarned = garbage.Weight * 400;
            return capitalEarned;
        }

        protected override double CalculateEnergybalance(IWaste garbage)
        {
            double energyProduced = 0;
            double energyUsed = garbage.CalculateWasteTotalVolume() * 0.5;

            return energyProduced - energyUsed;
        }
    }
}
