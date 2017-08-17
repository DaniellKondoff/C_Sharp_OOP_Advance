using RecyclingStation.BisinessLayer.Attributes;
using RecyclingStation.BisinessLayer.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Enteties.Garbages
{
    [StorableStrategy(typeof(StorableGarbageDisposalStrategy))]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double volumePerKg, double weight) 
            : base(name, volumePerKg, weight)
        {
        }
    }
}
