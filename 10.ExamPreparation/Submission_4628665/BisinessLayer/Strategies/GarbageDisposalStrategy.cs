using RecyclingStation.BisinessLayer.Data;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Strategies
{
    public abstract class GarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        protected abstract double CalculateEnergybalance(IWaste garbage);
        protected abstract double CalculateCapitalbalance(IWaste garbage);

        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyBalance = this.CalculateEnergybalance(garbage);
            double capitalbalance = this.CalculateCapitalbalance(garbage);

            return new ProcessingData(energyBalance, capitalbalance);
        }
    }
}
