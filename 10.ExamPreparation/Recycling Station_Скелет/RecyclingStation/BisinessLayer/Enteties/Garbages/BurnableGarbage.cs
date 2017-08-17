using RecyclingStation.BisinessLayer.Attributes;
using RecyclingStation.BisinessLayer.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Enteties.Garbages
{
    [BurnableStrategy(typeof(BurnableGarbageDisposalbeStrategy))]
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double volumePerKg, double weight) 
            : base(name, volumePerKg, weight)
        {
        }
    }
}
