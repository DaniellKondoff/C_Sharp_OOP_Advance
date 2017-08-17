using RecyclingStation.BisinessLayer.Attributes;
using RecyclingStation.BisinessLayer.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Enteties.Garbages
{
    [RecyclableStrategy(typeof(RecycableGarbageDisposalStrategy))]
    public class RecyclableGarbage : Garbage
    {
        public RecyclableGarbage(string name, double volumePerKg, double weight) 
            : base(name, volumePerKg, weight)
        {
        }
    }
}
