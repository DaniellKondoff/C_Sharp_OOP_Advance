using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BisinessLayer.Strategies
{
    public class BurnableGarbageDisposalbeStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateCapitalbalance(IWaste garbage)
        {
            return 0;
        }

        protected override double CalculateEnergybalance(IWaste garbage)
        {
            double energyProduced = garbage.CalculateWasteTotalVolume();
            double energyUsed = garbage.CalculateWasteTotalVolume()*0.2;

            return energyProduced - energyUsed;
        }
    }
}
