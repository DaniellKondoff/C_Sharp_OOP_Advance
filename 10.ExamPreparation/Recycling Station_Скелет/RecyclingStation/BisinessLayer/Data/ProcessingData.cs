using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Data
{
    public class ProcessingData : IProcessingData
    {
        private double energyBalance;
        private double capitalBalance;

        public ProcessingData(double energyBalance,double capitalBalance)
        {
            this.EnergyBalance = energyBalance;
            this.CapitalBalance = capitalBalance;
        }
        public double EnergyBalance
        {
            get
            {
                return energyBalance;
            }

           private set
            {
                energyBalance = value;
            }
        }

        public double CapitalBalance
        {
            get
            {
                return capitalBalance;
            }

            set
            {
                capitalBalance = value;
            }
        }

    }
}
