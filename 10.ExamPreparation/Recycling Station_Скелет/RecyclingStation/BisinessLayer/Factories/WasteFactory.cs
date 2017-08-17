using RecyclingStation.BisinessLayer.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Factories
{
    public class WasteFactory : IWasteFactory
    {
        private const string GarbageSuffix = "Garbage";
        public IWaste Create(string name,double weight,double volumePerKg,string type)
        {
            string fullTypename = type + GarbageSuffix;
            Type typeOfGarbageToActivate = Assembly.GetExecutingAssembly()
                .GetTypes().FirstOrDefault(t => t.Name.Equals(fullTypename, 
                    StringComparison.OrdinalIgnoreCase));

            object[] typeArgs = new object[] { name, weight, volumePerKg };

            IWaste waste = (IWaste)Activator.CreateInstance(typeOfGarbageToActivate, typeArgs);

            return waste;
        }
    }
}
