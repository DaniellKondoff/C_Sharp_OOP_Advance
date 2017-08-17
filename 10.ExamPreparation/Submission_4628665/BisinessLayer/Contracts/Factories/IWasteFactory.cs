using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Contracts.Factories
{
    public interface IWasteFactory
    {
        IWaste Create(string name, double wight, double volumePerKg, string type);

    }
}
