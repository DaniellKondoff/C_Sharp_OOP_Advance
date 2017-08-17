using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.WasteDisposal.Interfaces
{
    public static class WasteExtensionMethods
    {
        public static double CalculateWasteTotalVolume(this IWaste waste)
        {
            return waste.Weight * waste.VolumePerKg;
        }
    }
}
