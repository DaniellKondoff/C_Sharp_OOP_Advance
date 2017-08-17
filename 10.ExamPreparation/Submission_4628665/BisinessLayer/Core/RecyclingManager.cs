using RecyclingStation.BisinessLayer.Contracts.Core;
using RecyclingStation.BisinessLayer.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Core
{
    public class RecyclingManager : IRecyclingStation
    {
        private const string ProcessgarbageMessageToFormat = "{0} kg of {1} successfully processed!";
        private const string FloatingPointNumberFormat = "f2";
        private const string StatusMessageToFormat = "Energy: {0} Capital: {1}";

        private IGarbageProcessor garbageProcessor;
        private IWasteFactory wasteFactory;

        private double capitalBalance;
        private double energyBalance;

        public RecyclingManager(IGarbageProcessor garbageProcessor,IWasteFactory wasteFactory)
        {
            this.garbageProcessor = garbageProcessor;
            this.wasteFactory = wasteFactory;
        }
        public string ProcessGarbage(string name, double weight, double volumePerKg, string type)
        {
            IWaste someWaste = this.wasteFactory.Create(name,weight,volumePerKg,type);

            IProcessingData processedData =  this.garbageProcessor.ProcessWaste(someWaste);
            this.capitalBalance += processedData.CapitalBalance;
            this.energyBalance += processedData.EnergyBalance;

            string formatedMessage = string.Format(ProcessgarbageMessageToFormat, 
                someWaste.Weight.ToString(FloatingPointNumberFormat), 
                someWaste.Name);

            return formatedMessage;
        }

        public string Status()
        {
            string formattedMessage = string.Format(StatusMessageToFormat,
                this.energyBalance.ToString(FloatingPointNumberFormat),
                this.capitalBalance.ToString(FloatingPointNumberFormat));
            return formattedMessage;
        }
    }
}
